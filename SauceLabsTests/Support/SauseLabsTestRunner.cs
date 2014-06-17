using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSIL.SauceLabsTests.Support
{
    public class SauseLabsTestRunner
    {
        private readonly string _login;
        private readonly string _apiKey;
        private readonly string _baseAddress;
        private readonly string _tunnelId;

        public SauseLabsTestRunner(string baseAddress, string login, string apiKey, string tunnelId)
        {
            _baseAddress = baseAddress;
            _login = login;
            _apiKey = apiKey;
            _tunnelId = tunnelId;
        }

        public async Task<IEnumerable<TestResult>> Run(BrowserTestSuite testSuite, object browser)
        {
            var allTestResults = new List<TestResult>();
            var testName = "JSIL " + DateTime.Now.ToString("s");

            const int testPerPass = 20;
            do
            {
                var testResults = await Run(testName, allTestResults.Count, testPerPass, browser);
                allTestResults.AddRange(testResults);
            } while (allTestResults.Count < testSuite.Count);

            return allTestResults;
        }

        private async Task<IEnumerable<TestResult>> Run(string name, int startTest, int testCount, object browser)
        {
            var startTestArgs = @"{
            ""platforms"": [" + browser + @"],
            ""url"": """ + _baseAddress + "test_runner/parent.html?start=" + startTest + "&count=" + testCount + @""",
            ""framework"": ""custom"",
            ""max-duration"": 360,
            ""tunnel_identifier"" : """ + _tunnelId + @""",
            ""name"": """ + name + " " + (startTest + 1) + "-" + (startTest + testCount) + @"""
}";

            string response;
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential(_login, _apiKey);
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                response = await client.UploadStringTaskAsync("https://saucelabs.com/rest/v1/ikiselev/js-tests", "POST", startTestArgs);
            }

            var requestResult = JObject.Parse(response);
            var testId = (string)requestResult["js tests"][0];
            return await GetTestResults(testId);
        }

        private async Task<IEnumerable<TestResult>> GetTestResults(string testId)
        {
            var getTestResultsArgs = @"{
            ""js tests"": [""" + testId + @"""]
}";
            do
            {
                string response;
                using (var client = new WebClient())
                {
                    client.Credentials = new NetworkCredential("ikiselev", "5ee8e5fb-6ee0-439d-8930-3d09d3a64e8c");
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    response = client.UploadString(
                        "https://saucelabs.com/rest/v1/ikiselev/js-tests/status",
                        "POST",
                        getTestResultsArgs);
                }

                var requestResult = JObject.Parse(response);
                var isCompleted = (bool) requestResult["completed"];

                if (!isCompleted)
                {
                    await Task.Delay(TimeSpan.FromSeconds(15));
                }
                else
                {
                    var testResults = new List<TestResult>();

                    var resultUrl = new Uri((string)requestResult["js tests"][0]["url"]);

                    foreach (var testResult in requestResult["js tests"][0]["result"]["tests"])
                    {
                        testResults.Add(new TestResult(
                            (string)testResult["name"],
                            (bool)testResult["result"],
                            0,
                            resultUrl));
                    }

                    return testResults;
                }
            } while (true);
        }
    }
}