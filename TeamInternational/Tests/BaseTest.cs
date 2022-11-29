using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TeamInternational.Tests
{
    [TestFixture]
    class BaseTest {

        private static IWebDriver driver;
        private static ExtentTest test;
        private static ExtentReports extent;
        private static string _scrPath;

        [OneTimeSetUp]
        protected static void GlobalInitialSettings()
        {
            //Extent report initialization
            string date = DateTime.Now.ToString("_MMddyyyy_HHmmss");
            var reportPath = System.IO.Directory.CreateDirectory(Properties.System.EXTENT_REPORT_PATH) + "Report_" + date + "\\";
            _scrPath = reportPath + "captures\\";
            Directory.CreateDirectory(reportPath);
            var htmlreporter = new ExtentHtmlReporter(reportPath);
            Extent = new ExtentReports();
            Extent.AttachReporter(htmlreporter);

            //Driver initialization
            Driver = new ChromeDriver(Properties.System.CHROME_DRIVER_PATH);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Properties.System.PAGELOAD_TIMEOUT);
            Driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed) {
                Test.Fail(stackTrace + errorMessage);
                logScreenShotForFailure();
            }
            Extent.Flush();
        }

        [OneTimeTearDown]
        protected static void GlobalClose()
        {
            Driver.Close();
            Extent.Flush();
        }


        public static void logScreenShotForFailure ()
        {
            Test.Fail("Snapshot below: ").AddScreenCaptureFromPath(ScreenCapture());
        }

        private static string ScreenCapture()
        {
            Directory.CreateDirectory(_scrPath);
            ITakesScreenshot ts = (ITakesScreenshot)Driver;
            Screenshot screenshot = ts.GetScreenshot();
            string localPath = _scrPath + "Scr" + DateTime.Now.ToString("_MMddyyyy_HHmmss") + ".png";
            screenshot.SaveAsFile(localPath, ScreenshotImageFormat.Png);
            return localPath;
        }

        //This part is just to make it visible for the video, remove when done
        /*
        [TearDown]
        protected static void MakeEndingVisibleforAWhile()
        {
            Thread.Sleep(5 * 1000);
        }
        */

        public static IWebDriver Driver { get => driver; set => driver = value; }
        public static ExtentTest Test { get => test; set => test = value; }
        public static ExtentReports Extent { get => extent; set => extent = value; }
    }

}
