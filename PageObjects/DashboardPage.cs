using GailSpecFlow.Properties;
//using OpenQA.Selenium.DevTools.V105.CSS;
using OpenQA.Selenium.DevTools.V107.CSS;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace GailSpecFlow.PageObjects
{
    public class DashboardPage
    {
       // private IWebDriver driver;
        public DashboardPage()
        {
            //this.driver = driver;
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]")]       
        private IWebElement Toast;

        [FindsBy(How = How.XPath, Using ="//a[@id='menu~Customer On Boarding']")]
        public IWebElement Onboarding;

        [FindsBy(How = How.XPath, Using = "//a[@id='menu~Billing & Payment']")]
        public IWebElement Billing;
        public IWebElement Success() 
        {
            return Toast;
        }
        public IWebElement Menu() 
        {
            return Onboarding;
        }
        
    }
}
