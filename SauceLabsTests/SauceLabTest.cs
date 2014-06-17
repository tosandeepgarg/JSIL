using System;
using System.Linq;
using JSIL.SauceLabsTests.SauceLabsBrowsers;
using JSIL.SauceLabsTests.Support;
using NUnit.Framework;
using SauceLabs;

namespace JSIL.SauceLabsTests
{
    [TestFixture]
    public class SauceLabTest
    {
        private string _baseAddress;
        private string _login;
        private string _apiKey;
        private string _tunnelId;

        private TestSession _session;

        [TestFixtureSetUp]
        public void RunBeforeAnyTests()
        {
            _baseAddress = "http://localhost:9000/";
            _login = Credentials.username;
            _apiKey = Credentials.accessKey;
            _tunnelId = Guid.NewGuid().ToString();


            _session = new TestSession(_baseAddress, _login, _apiKey, _tunnelId);
        }

        [TestFixtureTearDown]
        public void RunAfterAllTests()
        {
            _session.Dispose();
        }

        [TestCase]
        public void BrowsersTest()
        {
            var testSuite = new BrowserTestSuite(true);

            var runner = new SauseLabsTestRunner(_baseAddress, _login, _apiKey, _tunnelId);
            var result = runner.Run(
                testSuite,
                TargetBrowser.Browsers.First(
                    item =>
                    item.Platform == Platform.Win8_1 && item.Browser == Browser.Chrome && item.Version == string.Empty))
                               .Result;

            Assert.AreEqual(
                0,
                result.Count(it => !it.Result),
                "Failed test list:\r\n"
                + string
                      .Join("\r\n",
                            result.Where(it => !it.Result)
                                  .Select(it => string.Format("{0} ({1})", it.Name, it.ResultInfo))));
        }
    }
}