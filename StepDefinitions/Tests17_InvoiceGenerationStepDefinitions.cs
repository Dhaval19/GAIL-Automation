using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Tests17_InvoiceGenerationStepDefinitions : DashboardPage
    {
        InvoicePage Ip = new InvoicePage();
        [Given(@"Wait For Page to Load")]
        public void GivenWaitForPageToLoad()
        {
            Thread.Sleep(3000);
            Billing.Click();
            Thread.Sleep(2000);
            Ip.InvoiceLink.Click();
            Thread.Sleep(3000);
        }

        [Then(@"Search Customer By BP No")]
        public void ThenSearchCustomerByBPNo()
        {
            Ip.BPSearch.SendKeys(VerifyValue.BPNo);
            Thread.Sleep(3000);
        }

        [Then(@"Selct Date Filter")]
        public void ThenSelctDateFilter()
        {
            Ip.FromDate.Click();
            Thread.Sleep(1000);
            Ip.Month.Click();
            Thread.Sleep(1000);
            Ip.JanMonth.Click();
            Thread.Sleep(1000);
            Ip.date.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Click On Generate Invoice Button")]
        public void ThenClickOnGenerateInvoiceButton()
        {            
            Ip.BtnPrint.Click();
            Thread.Sleep(3000);
            Ip.Yes.Click();
            Thread.Sleep(2000);
            PropertyCollection.driver.Quit();
        }
    }
}
