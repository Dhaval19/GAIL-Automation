using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class RFCPage
    {
        public RFCPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='RFC Status']")]
        public IWebElement RfcLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='RFC Done?']")]
        public IWebElement BtnRfc;

        [FindsBy(How = How.XPath, Using = "//button[@class='confirm']")]
        public IWebElement Yes;
        
    }
}
