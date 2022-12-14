using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class SDByPassPage
    {
        public SDByPassPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='SD ByPass InterLock For Move-In']")]
        public IWebElement ByPassLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='ConsumerNumber']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSave']")]
        public IWebElement BtnSave;

        [FindsBy(How = How.XPath, Using = "//button[@class='confirm']")]
        public IWebElement Yes;

    }
}
