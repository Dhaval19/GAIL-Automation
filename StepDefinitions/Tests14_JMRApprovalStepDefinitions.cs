using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Tests14_JMRApprovalStepDefinitions : DashboardPage
    {
        GasInApprovePage Gap = new GasInApprovePage();
        [Given(@"Verify JMR Approval PAge Loaded")]
        public void GivenVerifyJMRApprovalPAgeLoaded()
        {
            Thread.Sleep(5000);
            Onboarding.Click();
            Thread.Sleep(2000);
            Gap.ApproveLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Search Customer JMR Record")]
        public void ThenSearchCustomerJMRRecord()
        {
            Gap.BPSearch.SendKeys(VerifyValue.BPNo);
            Gap.BtnSearch.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Save Approve JMR Details")]
        public void ThenSaveApproveJMRDetails()
        {
            Gap.BtnJMRAdd.Click();
            Thread.Sleep(2000);
            Gap.BtnApprove.Click();
        }
    }
}
