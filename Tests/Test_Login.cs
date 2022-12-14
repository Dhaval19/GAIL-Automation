using GailSpecFlow.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Diagnostics;
using AventStack.ExtentReports.Model;
using GailSpecFlow.Properties;

namespace Tests
{
    public class Test_Login
    {               
        public void GetLogin()
        {  
            try
            {
                Thread.Sleep(1000);
                var adv = PropertyCollection.driver.FindElement(By.XPath("/html/body/div/div[2]/button[3]"));
                if (adv.Displayed)
                {
                    adv.Click();
                    PropertyCollection.driver.FindElement(By.XPath("//*[@id=\"proceed-link\"]")).Click();
                }
            }
            catch (Exception)
            {
                throw;
            }
            LoginPage lp = new LoginPage();
            lp.GetUsername().SendKeys("Dhavals");
            lp.GetPassword().SendKeys("123456");
            lp.Captcha.SendKeys("");
            Thread.Sleep(10000);
            lp.LoginClick();            
        }
    }
}
