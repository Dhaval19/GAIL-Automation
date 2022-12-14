using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using GailSpecFlow.PageObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Commands;
using GailSpecFlow.PageObjects;


namespace Tests
{
    public class Utility 
    {
        //public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest TestReport;
        
        public void StartBrowser()
        {
            // Adding Entry In Report
            
            // Configuration
            try
            {
                //string browsername = ConfigurationManager.AppSettings["browser"];
                string browsername = "Chrome";
                InitBrowser(browsername);
                PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PropertyCollection.driver.Manage().Window.Maximize();
                PropertyCollection.driver.Navigate().GoToUrl("https://admintest.gailgas-png.in/");               
            }
            catch (Exception)
            {              
                throw;
            }
    
        }
        public void InitBrowser(string Brower)
        {
            switch (Brower)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    PropertyCollection.driver = new ChromeDriver();
                    PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    break;

                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    PropertyCollection.driver = new FirefoxDriver();
                    PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    break;
            }
        }
        public static void ClickToast() 
        {
            DashboardPage Dash = new DashboardPage();
            IWebElement Toast = Dash.Success();
            Toast.Click();
        }

        [OneTimeSetUp]
        public void Setup()
        {
            //string WorkingDirectory = Directory.GetCurrentDirectory();
            //string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.Parent.FullName;
            //string ReportPath = ProjectDirectory + "//Report.html";
            //var HtmlReporter = new ExtentHtmlReporter(ReportPath);
            //extent = new ExtentReports();
            //extent.AttachReporter(HtmlReporter);

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            String reportPath = projectDirectory + "//report.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Server", "UAT Server");
            extent.AddSystemInfo("Tester Name", "Dhaval Shrimali");
        }
        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver, string ScreenshotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            string Screenshot = ts.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(Screenshot, ScreenshotName).Build();
        }
        [OneTimeTearDown]
        public void AfterTest()
        {
            // Report Status
            DateTime time = DateTime.Now;
            string filename = "Screenshot" + time.ToString("h_mm_ss") + ".png";
            var ReportStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var TestLog = TestContext.CurrentContext.Result.StackTrace;
            if (ReportStatus == TestStatus.Failed)
            {
                TestReport.Fail("Test Failed", CaptureScreenshot(PropertyCollection.driver, filename));
                TestReport.Log(Status.Fail, "Failed Test Log" + TestLog);
            }
            else if (ReportStatus == TestStatus.Passed)
            {
                //TestReport.Fail("Test Passed", CaptureScreenshot(driver, filename));
                //TestReport.Log(Status.Pass, "Passed Test Log" + TestLog);
            }
            extent.Flush();
        }


    }
}
