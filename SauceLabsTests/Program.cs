using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using JSIL.Internal;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.StaticFiles;
using NUnit.Framework;
using Owin;

namespace SauceLabsTests
{
    class Program
    {
        private static void Main(string[] args)
        {
            var tests = new SauceLabTest();
            tests.RunBeforeAnyTests();
            Console.ReadLine();
            tests.BrowsersTest();
            tests.RunAfterAllTests();
            Console.ReadLine();
        }
    }

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
            _login = "ikiselev";
            _apiKey = "5ee8e5fb-6ee0-439d-8930-3d09d3a64e8c";
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

    public class TestSession : IDisposable
    {
        private string _baseAddress;
        private string _login;
        private string _apiKey;
        private string _tunnelId;

        private string _logPath;

        private readonly Process _proxy;
        private readonly IDisposable _host;

        private bool _isDisposed;

        public TestSession(string baseAddress, string login, string apiKey, string tunnelId)
        {
            _baseAddress = baseAddress;
            _login = login;
            _apiKey = apiKey;
            _tunnelId = tunnelId;

            _host = RunWebServer();
            _proxy = StartProxy();
        }

        public void Dispose()
        {
            if (!_isDisposed)
            {
                _isDisposed = true;

                Console.Write("Closing session... ");

                if (_proxy != null)
                {
                    _proxy.CloseMainWindow();
                    _proxy.WaitForExit(10000);
                    _proxy.Kill();
                    _proxy.Dispose();
                }

                if (_host != null)
                {
                    _host.Dispose();
                }

                Console.WriteLine("closed.");
            }
        }

        private IDisposable RunWebServer()
        {
            return WebApp.Start(
                _baseAddress,
                builder => builder.UseFileServer(new FileServerOptions
                    {
                        FileSystem = new PhysicalFileSystem(".."),
                        StaticFileOptions =
                            {
                                ServeUnknownFileTypes = true
                            }
                    }));
        }

        private Process StartProxy()
        {
            Process proxy = null;

            var assemblyPath = Path.GetDirectoryName(
                Util.GetPathOfAssembly(Assembly.GetExecutingAssembly())
            );

            var TempPath = Path.GetTempPath();
            _logPath = Path.Combine(TempPath, string.Format("sc_{0}.log", _tunnelId));

            var psi = new ProcessStartInfo(
                Path.GetFullPath(Path.Combine(
                    assemblyPath, @"..\Upstream\SauceLabs\sc.exe"
                )),
                String.Format(
                    "-u {0} -k {1} -i {2}",
                    _login,
                    _apiKey,
                    _tunnelId
                )
            )
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                ErrorDialog = false,
                WorkingDirectory = TempPath
            };

            if (File.Exists(_logPath))
                File.Delete(_logPath);

            PassOrFail(
                () => proxy = Process.Start(psi),
                "Starting proxy", "started."
            );

            PassOrFail(
                () => WaitForProxyLogText(proxy, "CLI Connection established."),
                "Waiting for proxy connection", "connected."
            );

            return proxy;
        }

        private void WaitForProxyLogText(Process proxy, string searchText, int timeoutMs = 60000)
        {
            var started = DateTime.UtcNow.Ticks;
            var timeoutAt = started + TimeSpan.FromMilliseconds(timeoutMs).Ticks;

            while (DateTime.UtcNow.Ticks < timeoutAt)
            {
                if (proxy.HasExited)
                    throw new Exception("Process terminated prematurely with exit code " + proxy.ExitCode);

                if (File.Exists(_logPath))
                    break;
                Thread.Sleep(100);
            }

            using (var stream = new FileStream(_logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                while (DateTime.UtcNow.Ticks < timeoutAt)
                {
                    if (proxy.HasExited)
                        throw new Exception("Process terminated prematurely with exit code " + proxy.ExitCode);

                    stream.Seek(0, SeekOrigin.Begin);
                    var buffer = new byte[stream.Length];
                    var bytesRead = stream.Read(buffer, 0, buffer.Length);

                    var logText = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    if (logText.Contains(searchText))
                        return;

                    Thread.Sleep(100);
                }

            throw new Exception("Timed out without seeing expected log text");
        }

        private void PassOrFail(Action action, string caption, string passText = "succeeded.", string failText = "failed.")
        {
            PassOrFail<object>(
                () =>
                {
                    action();
                    return null;
                }, caption, passText, failText
            );
        }

        private T PassOrFail<T>(Func<T> fn, string caption, string passText = "succeeded.", string failText = "failed.")
        {
            T result;

            Console.Write(caption + "... ");
            try
            {
                result = fn();
                Console.WriteLine(passText);
            }
            catch (Exception)
            {
                Console.WriteLine(failText);
                throw;
            }

            return result;
        }
    }
}
