using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_RFCDone
    {
        RFCPage Rp = new RFCPage();
        DashboardPage Dp = new DashboardPage();
        public void RFCDone()
        {
            Thread.Sleep(3000);
            Dp.Onboarding.Click();
            Thread.Sleep(3000);
            Rp.RfcLink.Click();
            Rp.BPSearch.SendKeys(VerifyValue.BPNo);
            Rp.BtnSearch.Click();
            Thread.Sleep(1000);
            Rp.BtnRfc.Click();
            Thread.Sleep(2000);
            Rp.Yes.Click();
        }
    }
}
