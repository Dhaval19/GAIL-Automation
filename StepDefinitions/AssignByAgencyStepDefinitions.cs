using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class AssignByAgencyStepDefinitions : DashboardPage
    {
        ByAgencyPage Byp = new ByAgencyPage();       
        ByAgencyValue Bav = new ByAgencyValue();
        [Given(@"Verify Page Is Loaded Or Not")]
        public void GivenVerifyPageIsLoadedOrNot()
        {
            Thread.Sleep(3000);
            Onboarding.Click();
            Byp.ByAgencyLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Search By BP No")]
        public void ThenSearchByBPNo()
        {
            Methods.Dropdown(Byp.Agency, Bav.Agency);
            Byp.BPSearch.SendKeys(VerifyValue.BPNo);
            Byp.BtnSearch.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Select Record And Supervisor")]
        public void ThenSelectRecordAndSupervisor()
        {
            Byp.SelectAll.Click();
            Methods.Dropdown(Byp.Supervisor, Bav.Supervisor);
        }

        [Then(@"click On Assign Button")]
        public void ThenClickOnAssignButton()
        {
            Byp.BtnAssign.Click();
            Thread.Sleep(3000);
            Byp.Yes.Click();
        }
    }
}
