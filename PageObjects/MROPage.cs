using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class MROPage
    {
        public MROPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='MRO Generation']")]
        public IWebElement MROLink;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='ConsumerCode']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='KWH']//ins[@class='iCheck-helper']")]
        public IWebElement MRU;

        [FindsBy(How = How.XPath, Using = "//input[@id='btnSave']")]
        public IWebElement BtnSave;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[10]")]
        public IWebElement Status;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[7]")]
        public IWebElement Succeed;
        
    }
}
