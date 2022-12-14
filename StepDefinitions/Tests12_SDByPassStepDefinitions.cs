using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Tests12_SDByPassStepDefinitions : DashboardPage
    {
        SDByPassPage Sbp = new SDByPassPage();
        [Given(@"Check Page Is Loaded")]
        public void GivenCheckPageIsLoaded()
        {
            Thread.Sleep(5000);
            Onboarding.Click();
            Thread.Sleep(3000);
            Sbp.ByPassLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Add Details")]
        public void ThenAddDetails()
        {
            Sbp.BPSearch.SendKeys(VerifyValue.BPNo);
        }

        [Then(@"Save Record")]
        public void ThenSaveRecord()
        {
            Sbp.BtnSave.Click();
            Thread.Sleep(2000);
            Sbp.Yes.Click();
        }
    }
}
