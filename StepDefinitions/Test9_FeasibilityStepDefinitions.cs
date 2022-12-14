using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Test9_FeasibilityStepDefinitions : DashboardPage
    {
        FeasibilityPage Fp = new FeasibilityPage();       
        FeasibleValue Fv = new FeasibleValue();
        [Given(@"Verify Feasiblity Page Is Loaded Or Not")]
        public void GivenVerifyFeasiblityPageIsLoadedOrNot()
        {
            Thread.Sleep(2000);
            Onboarding.Click();
            Thread.Sleep(2000);
            Fp.FeasibileLink.Click();
        }

        [Then(@"Search Customer")]
        public void ThenSearchCustomer()
        {
            Fp.BPSearch.SendKeys(VerifyValue.BPNo);
            Fp.BtnSearch.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Fill Form Details")]
        public void ThenFillFormDetails()
        {
            Fp.BtnAdd.Click();
            Thread.Sleep(1000);
            Fp.Piping.SendKeys(Fv.PipingValue);
        }

        [Then(@"Save Form")]
        public void ThenSaveForm()
        {
            Fp.SavePiping.Click();
            Thread.Sleep(3000);
        }
    }
}
