using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage lp = new LoginPage();
        [Given(@"Verify Login Page Is Loaded")]
        public void GivenVerifyLoginPageIsLoaded()
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
        }

        [Then(@"Enter Username")]
        public void ThenEnterUsername()
        {
            lp.GetUsername().SendKeys("Dhavals");
        }

        [Then(@"Enter Password")]
        public void ThenEnterPassword()
        {
            lp.GetPassword().SendKeys("123456");
        }

        [Then(@"Enter Captcha")]
        public void ThenEnterCaptcha()
        {
            lp.Captcha.SendKeys("");
        }

        [Then(@"Click On Loading Button")]
        public void ThenClickOnLoadingButton()
        {
            Thread.Sleep(10000);
            lp.LoginClick();
        }
    }
}
