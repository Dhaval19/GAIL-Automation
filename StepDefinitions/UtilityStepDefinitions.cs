using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using GailSpecFlow.Properties;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class UtilityStepDefinitions
    {
        public static ExtentReports extent;
        public static ExtentTest TestReport;
        private static ExtentTest featureName;
        private ExtentTest scenario;

        [Given(@"Verify Driver Is Loaded")]
        
        public void GivenVerifyDriverIsLoaded()
        {
            
            try
            {
                string browsername = "Chrome";
                
                OpenBrowser(browsername);
                PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                PropertyCollection.driver.Manage().Window.Maximize();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void OpenBrowser(string? browsername)
        {
            switch (browsername)
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

        [Then(@"Open Broswer \(""([^""]*)""\)")]
        public void ThenOpenBroswer(string browser)
        {
            Console.WriteLine(browser);
        }

        [Then(@"Navigate to URL")]
        public void ThenNavigateToURL()
        {
            PropertyCollection.driver.Navigate().GoToUrl("https://admintest.gailgas-png.in/");
        }

    }
}
