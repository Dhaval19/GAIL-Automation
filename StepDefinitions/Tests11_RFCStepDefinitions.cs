using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Tests11_RFCStepDefinitions : DashboardPage
    {
        RFCPage Rp = new RFCPage();
        [Given(@"Verify RFC Done Page Is Loaded")]
        public void GivenVerifyRFCDonePageIsLoaded()
        {
            Thread.Sleep(3000);
            Onboarding.Click();
            Thread.Sleep(3000);
            Rp.RfcLink.Click();
        }

        [Then(@"Search Customer For RFC")]
        public void ThenSearchCustomerForRFC()
        {
            Rp.BPSearch.SendKeys(VerifyValue.BPNo);
            Rp.BtnSearch.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Save RFC Details")]
        public void ThenSaveRFCDetails()
        {
            Rp.BtnRfc.Click();
            Thread.Sleep(2000);
            Rp.Yes.Click();
        }
    }
}
