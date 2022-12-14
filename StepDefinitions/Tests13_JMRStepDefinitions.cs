using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Tests13_JMRStepDefinitions : DashboardPage
    {
        GasInPage Gp = new GasInPage();
        GasInValue Gv = new GasInValue();
        [Given(@"Verify JMR Gas Page Loaded")]
        public void GivenVerifyJMRGasPageLoaded()
        {
            Thread.Sleep(3000);
            Onboarding.Click();
            Thread.Sleep(2000);
            Gp.GasInLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Search Record")]
        public void ThenSearchRecord()
        {
            Gp.BPSearch.SendKeys(VerifyValue.BPNo);
            Gp.BtnSearch.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Add JMR Details")]
        public void ThenAddJMRDetails()
        {
            Gp.BtnAdd.Click();
            Thread.Sleep(2000);
            Gp.JMRDate.SendKeys(Gv.JMRDate);
            Methods.Dropdown(Gp.DDMRU, Gv.MRUID);
            Thread.Sleep(1000);
            Gp.JMRFile.SendKeys(Gv.JMRFile);
            Thread.Sleep(2000);
        }

        [Then(@"Save JMR Details")]
        public void ThenSaveJMRDetails()
        {
            Gp.BtnSave.Click();
        }
    }
}
