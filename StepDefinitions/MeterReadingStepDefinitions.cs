using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class MeterReadingStepDefinitions : DashboardPage
    {
        MeterReadingPage Mrp = new MeterReadingPage();
        MeterReadingValue Mrv = new MeterReadingValue();

        [Given(@"Verify Meter Reading Page Is Loaded")]
        public void GivenVerifyMeterReadingPageIsLoaded()
        {
            Thread.Sleep(3000);
            Billing.Click();
            Thread.Sleep(2000);
            Mrp.MeterReadingLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Enter BP Number In Search Box")]
        public void ThenEnterBPNumberInSearchBox()
        {
            Mrp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mrp.BtnSearch.Click();            
            Thread.Sleep(2000);
        }

        [Then(@"Enter Current Reading And Meter Image")]
        public void ThenEnterCurrentReadingAndMeterImage()
        {
            Mrp.ReadingDate.SendKeys(Mrv.ReadingDate);
            Mrv.CurrentReading = Methods.GetCurrentReading();
            Mrp.CurrentReading.SendKeys(Mrv.CurrentReading.ToString());
            Mrp.MeterImage.SendKeys(Mrv.MeterImage);
            Thread.Sleep(2000);
        }

        [Then(@"Click On Save Button To Generate Invoice")]
        public void ThenClickOnSaveButtonToGenerateInvoice()
        {
            var Oldtab = PropertyCollection.driver.CurrentWindowHandle;
            Mrp.BtnSave.Click();
            Mrp.BtnSave.Click();
            Thread.Sleep(3000);
            PropertyCollection.driver.SwitchTo().Window(Oldtab);
        }
    }
}
