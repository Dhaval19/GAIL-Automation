using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using OpenQA.Selenium.DevTools.V85.IndexedDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_MeterReading
    {
        MeterReadingPage Mrp = new MeterReadingPage();
        MeterReadingValue Mrv = new MeterReadingValue();
        DashboardPage Dp = new DashboardPage();
        public void DoMeterReading() 
        {
            Thread.Sleep(3000);
            Dp.Billing.Click();
            Thread.Sleep(2000);
            Mrp.MeterReadingLink.Click();
            Thread.Sleep(2000);
            Mrp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mrp.BtnSearch.Click();
            var Oldtab = PropertyCollection.driver.CurrentWindowHandle;
            Thread.Sleep(2000);
            Mrp.ReadingDate.SendKeys(Mrv.ReadingDate);
            Mrv.CurrentReading=Methods.GetCurrentReading();
            Mrp.CurrentReading.SendKeys(Mrv.CurrentReading.ToString());
            Mrp.MeterImage.SendKeys(Mrv.MeterImage);
            Thread.Sleep(2000);
            Mrp.BtnSave.Click();
            Mrp.BtnSave.Click();
            Thread.Sleep(3000);
            PropertyCollection.driver.SwitchTo().Window(Oldtab);
        }
    }
}
