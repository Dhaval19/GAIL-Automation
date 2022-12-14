using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class GasInPage
    {
        public GasInPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='JMR & Gas-In']")]
        public IWebElement GasInLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        public IWebElement BtnAdd;

        [FindsBy(How = How.XPath, Using = "//input[@id='JMRDate']")]
        public IWebElement JMRDate;

        // Dropdown Word Value = 25
        [FindsBy(How = How.XPath, Using = "//select[@id='WardId']")]
        public IWebElement DDMRU;

        [FindsBy(How = How.XPath, Using = "//input[@id='UploadJMR']")]
        public IWebElement JMRFile;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSave9']")]
        public IWebElement BtnSave;
    }
}
