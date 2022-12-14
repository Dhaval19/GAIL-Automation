using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Test15_MROStepDefinitions : DashboardPage
    {
        MROPage Mp = new MROPage();
        [Given(@"Verify MRO Page Is Loaded")]
        public void GivenVerifyMROPageIsLoaded()
        {
            Thread.Sleep(3000);
            Billing.Click();
            Thread.Sleep(2000);
            Mp.MROLink.Click();
            Thread.Sleep(3000);
        }

        [Then(@"Add BP Number In Search Box")]
        public void ThenAddBPNumberInSearchBox()
        {
            Mp.BPSearch.SendKeys(VerifyValue.BPNo);
        }

        [Then(@"Select MRU From Options")]
        public void ThenSelectMRUFromOptions()
        {
            Mp.MRU.Click();
        }

        [Then(@"Click On MRO Generation Button")]
        public void ThenClickOnMROGenerationButton()
        {
            Mp.BtnSave.Click();
        }

        [Then(@"Refresh Page Until MRO Generation Process Gets Completed")]
        public void ThenRefreshPageUntilMROGenerationProcessGetsCompleted()
        {
            Methods.MROValidation();
        }
    }
}
