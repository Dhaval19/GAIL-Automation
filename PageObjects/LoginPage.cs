using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GailSpecFlow.Properties;

namespace GailSpecFlow.PageObjects
{
    
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage()
        {
            // this.driver = driver;
            PageFactory.InitElements(PropertyCollection.driver,this);
        }
        // Page Factory
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement Username;

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//input[@id='CaptchaInputText']")]
        public IWebElement Captcha;    

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Force Login !')]")]
        private IWebElement Confirm;
        
        public IWebElement GetUsername() 
        {
            return Username;
        }
        public IWebElement GetPassword()
        {
            return Password;
        }
        public void LoginClick() 
        {
            LoginButton.Click();
            try 
            {                
                //button[contains(text(),'Login')]
                Thread.Sleep(3000);
                var test = PropertyCollection.driver.FindElement(By.XPath("//button[@class='confirm']"));
                Thread.Sleep(2000);
                if (test.Displayed)
                {
                    //WebDriverWait wait = new WebDriverWait(PropertyCollection.driver, TimeSpan.FromSeconds(5000));
                    //Thread.Sleep(2000);
                    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Force Login !')]"))).Click();
                    test.Click();
                    Console.WriteLine("Force Logged In");
                }

            }            
            catch (Exception)
            {
                Console.WriteLine("Popup Not Found");
                Console.WriteLine("Logged In Normally");
                //throw;    
            }
            
        }
    
    }

}
