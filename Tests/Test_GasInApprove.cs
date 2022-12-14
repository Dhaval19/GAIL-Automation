using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_GasInApprove
    {
        GasInApprovePage Gap = new GasInApprovePage();
        DashboardPage Dp = new DashboardPage();
        public void GasInApprove() 
        {
            Thread.Sleep(5000);
            Dp.Onboarding.Click();
            Thread.Sleep(2000);
            Gap.ApproveLink.Click();
            Thread.Sleep(2000);
            Gap.BPSearch.SendKeys(VerifyValue.BPNo);
            Gap.BtnSearch.Click();
            Thread.Sleep(1000);
            Gap.BtnJMRAdd.Click();
            Thread.Sleep(2000);
            Gap.BtnApprove.Click();
        }
    }
}
