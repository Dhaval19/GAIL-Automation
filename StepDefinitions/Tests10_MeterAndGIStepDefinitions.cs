using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Tests10_MeterAndGIStepDefinitions :DashboardPage
    {
        MeterGIPage Mgp = new MeterGIPage();
        MeterGIValue Mgv = new MeterGIValue();
        [Given(@"Verify Meter & GI Page Loaded")]
        public void GivenVerifyMeterGIPageLoaded()
        {
            Thread.Sleep(5000);
            Onboarding.Click();
            Thread.Sleep(3000);
            Mgp.MeterLink.Click();
        }

        [Then(@"Search Customer Record")]
        public void ThenSearchCustomerRecord()
        {
            Mgp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mgp.BtnSearch.Click();
            Thread.Sleep(3000);
        }

        [Then(@"Add Meter Details")]
        public void ThenAddMeterDetails()
        {
            Mgp.BtnAdd.Click();
            Thread.Sleep(2000);
            Methods.Dropdown(Mgp.DDMeterMake, Mgv.MeterMake);
            Mgp.MeterNo.SendKeys(Mgv.MeterNo);
            Mgp.SwitchOnDate.SendKeys(Mgv.MeterDate);
            Mgp.BtnSave.Click();
        }

        [Then(@"Add GI Piping Details")]
        public void ThenAddGIPipingDetails()
        {
            Thread.Sleep(3000);
            Mgp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mgp.BtnSearch.Click();
            Thread.Sleep(3000);
            Mgp.BtnGi.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Save Details")]
        public void ThenSaveDetails()
        {
            Mgp.BtnGiSave.Click();
        }
    }
}
