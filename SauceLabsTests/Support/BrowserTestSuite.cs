using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using JSIL.Internal;
using JSIL.Tests;
using NUnit.Framework;

namespace JSIL.SauceLabsTests.Support
{
    public class BrowserTestSuite
    {
        public BrowserTestSuite(bool build = true)
        {
            var tests = new BrowserTests();
            var testCases = tests.GetBrowserTests().ToArray();
            if (build)
            {
                var sb = new StringBuilder();
                foreach (var testCaseData in testCases)
                {
                    sb.AppendLine(
                        string.Format(
                            "{{id: \"{0}\", url: \"../Tests/{1}.out\", expectedResult: \"{2}\"}},"
                            , testCaseData.Description.Replace("\\", "\\\\"),
                            testCaseData.Description.Replace('\\', '/'),
                            tests.GetTestOutput((object[]) testCaseData.Arguments[0])));
                }

                var preparedOutput = string.Join(Environment.NewLine, "var tests = [", sb.ToString(), "];");
                File.WriteAllText(@"..\test_runner\tests.js", preparedOutput);
            }

            Count = testCases.Count();
        }

        public int Count { get; private set; }

        private class BrowserTests : ComparisonTests
        {
            public IEnumerable<TestCaseData> GetBrowserTests()
            {
                return SimpleTestCasesSource();
            }

            public string GetTestOutput(object[] parameters)
            {
                return GetTestOutput(
                    (string)parameters[0],
                    (TypeInfoProvider)parameters[1],
                    (AssemblyCache)parameters[2],
                    (string)parameters[3],
                    (bool)parameters[4]);
            }

            protected ComparisonTest MakeTest(
                string filename, string[] stubbedAssemblies = null,
                TypeInfoProvider typeInfo = null,
                AssemblyCache assemblyCache = null)
            {
                return base.MakeTest(filename, stubbedAssemblies, typeInfo, assemblyCache);
            }

            protected string GetTestOutput(
                string path,
                TypeInfoProvider typeInfoProvider,
                AssemblyCache cache,
                string commonFile,
                bool disposeCacheAndProvider)
            {
                var test = base.MakeTest(path, null, typeInfoProvider, cache);
                string outputs = null;
                var signals = new[] { new ManualResetEventSlim(false), new ManualResetEventSlim(false) };

                ThreadPool.QueueUserWorkItem((_) =>
                    {
                        long elapsed;
                        var oldCulture = Thread.CurrentThread.CurrentCulture;
                        try
                        {
                            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                            outputs =
                                test.RunCSharp(new string[0], out elapsed)
                                    .Replace(Environment.NewLine, "\n")
                                    .Replace("\r", "\\r")
                                    .Replace("\n", "\\n")
                                    .Replace("\"", "\\\"")
                                    .Trim();
                        }
                        catch (Exception ex)
                        {
                        }
                        finally
                        {
                            Thread.CurrentThread.CurrentCulture = oldCulture;
                        }
                        signals[0].Set();
                    });
                ThreadPool.QueueUserWorkItem((_) =>
                    {
                        try
                        {
                            string generatedJs;
                            long elapsed;
                            test.GenerateJavascript(new string[0], out generatedJs, out elapsed);
                        }
                        catch (Exception ex)
                        {
                        }
                        signals[1].Set();
                    });


                signals[0].Wait();
                signals[1].Wait();

                return outputs;
            }
        }

    }
}