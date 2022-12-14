using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace GailSpecFlow.PageObjects
{
    public class RegistrationPage
    {
        // IWebDriver driver = Utility.driver;
        public RegistrationPage()
        {
            // this.driver = driver;
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        // Link
        [FindsBy(How = How.XPath, Using = "//body/div[@id='wrapper']/div[@id='page-wrapper']/div[2]/nav[1]/div[2]/ul[1]/ul[1]/li[1]/a[1]")]
        public IWebElement RegLink;

        //Fields
        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement Fname;

        [FindsBy(How = How.XPath, Using = "//input[@id='MiddleName']")]
        public IWebElement Mname;

        [FindsBy(How = How.XPath, Using = "//input[@id='HouseNo']")]
        public IWebElement HouseNo;

        [FindsBy(How = How.XPath, Using = "//input[@id='Society']")]
        public IWebElement Society;

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement street;

        [FindsBy(How = How.XPath, Using = "//input[@id='PinCode']")]
        public IWebElement Pincode;

        [FindsBy(How = How.XPath, Using = "//input[@id='MobileNumber']")]
        public IWebElement Mno;

        [FindsBy(How = How.XPath, Using = "//input[@id='EmailId']")]
        public IWebElement Email;

        // Buttons
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSave']")]
        public IWebElement Save;

        // Dropdowns
        [FindsBy(How = How.XPath, Using = "//select[@id='TypeOfHouse']")]
        public IWebElement TypeOfHouse;

        [FindsBy(How = How.XPath, Using = "//select[@id='Floor']")]
        public IWebElement Floor;

        [FindsBy(How = How.XPath, Using = "//select[@id='AreaId']")]
        public IWebElement Area;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[2]")]
        public IWebElement Yes;
    }
}
