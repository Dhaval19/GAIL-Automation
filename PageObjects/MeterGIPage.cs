using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class MeterGIPage
    {
        public MeterGIPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Meter, GI Installation']")]
        public IWebElement MeterLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add')]")]
        public IWebElement BtnAdd;

        // Value = 1
        [FindsBy(How = How.XPath, Using = "//select[@id='MeterCompanyId']")]
        public IWebElement DDMeterMake;

        [FindsBy(How = How.XPath, Using = "//input[@id='MeterSerialNo']")]
        public IWebElement MeterNo;

        [FindsBy(How = How.XPath, Using = "//input[@id='TransactionDate']")]
        public IWebElement SwitchOnDate;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSave']")]
        public IWebElement BtnSave;

        // GI Elements
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSaveGIStatusData']")]
        public IWebElement BtnGi;

        [FindsBy(How = How.XPath, Using = "//div[@class='icheckbox_square-green']//ins[@class='iCheck-helper']")]
        public IWebElement GiPiping;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnExtpipingSave']")]
        public IWebElement BtnGiSave;

    }
}
