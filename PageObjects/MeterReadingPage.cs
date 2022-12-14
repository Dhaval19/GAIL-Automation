using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class MeterReadingPage
    {
        public MeterReadingPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Meter Reading']")]
        public IWebElement MeterReadingLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='ConsumerNumber']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//input[@id='ReadingDate']")]
        public IWebElement ReadingDate;

        [FindsBy(How = How.XPath, Using = "//input[@id='PreviousReading']")]
        public IWebElement PrevReading;

        [FindsBy(How = How.XPath, Using = "//input[@id='CurrentReading']")] 
        public IWebElement CurrentReading;

        [FindsBy(How = How.XPath, Using = "//input[@id='UploadedFile']")]
        public IWebElement MeterImage;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSubmit']")]
        public IWebElement BtnSave;
        
    }
}
