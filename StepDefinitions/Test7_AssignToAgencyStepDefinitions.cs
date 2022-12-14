using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Test7_AssignToAgencyStepDefinitions : DashboardPage
    {
        ToAgencyPage Ap = new ToAgencyPage();
        ToAgencyValue Av = new ToAgencyValue();
        [Given(@"Verify Page Is Loaded")]
        public void GivenVerifyPageIsLoaded()
        {
            Thread.Sleep(2000);
            //Methods.Wait(Dp.Onboarding);
            Onboarding.Click();
            Ap.ToAgencyLink.Click();
        }

        [Then(@"Search By App No")]
        public void ThenSearchByAppNo()
        {
            Ap.BPSearch.SendKeys(VerifyValue.BPNo);
            Thread.Sleep(2000);
            Ap.BtnSearch.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Assign Record to Agency")]
        public void ThenAssignRecordToAgency()
        {
            Ap.SelectAll.Click();
            Methods.Dropdown(Ap.Agency, Av.AgencyId);
            Thread.Sleep(2000);
        }

        [Then(@"Click On Assign Button")]
        public void ThenClickOnAssignButton()
        {
            Ap.BtnAssign.Click();
            Thread.Sleep(3000);
            Ap.Yes.Click();
        }
    }
}
