using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class InvoicePage
    {
        public InvoicePage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Invoice Generation']")]
        public IWebElement InvoiceLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='start']")]
        public IWebElement FromDate;

        [FindsBy(How = How.CssSelector, Using = "table[class=' table-condensed'] th[class='datepicker-switch']")]
        public IWebElement Month;

        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='Jan']")]
        public IWebElement JanMonth;

        [FindsBy(How = How.XPath, Using = "//td[@class='day'][normalize-space()='1']")]
        public IWebElement date;
        
        [FindsBy(How = How.XPath, Using = "//textarea[@id='ConsumerCode']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnPrint']")]
        public IWebElement BtnPrint;

        [FindsBy(How = How.XPath, Using = "//button[@class='confirm']")]
        public IWebElement Yes;
        
    }
}
