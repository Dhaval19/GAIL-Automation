using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using OpenQA.Selenium.DevTools.V107.CSS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace GailSpecFlow.Tests 
{
    
    public class Test_Dashboard 
    {
        DashboardPage Dp = new DashboardPage();
        public void Menu() 
        {
            PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement m = Dp.Menu();
            TestContext.WriteLine(m.Text);
            Thread.Sleep(2000);
            m.Click();
            Thread.Sleep(1000);   
        }
    }
}
