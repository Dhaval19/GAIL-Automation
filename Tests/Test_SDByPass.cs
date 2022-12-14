using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_SDByPass
    {
        SDByPassPage Sbp = new SDByPassPage();
        DashboardPage Dp = new DashboardPage();
        public void SDByPassMoveIn() 
        {
            Thread.Sleep(5000);
            Dp.Onboarding.Click();
            Thread.Sleep(2000);
            Sbp.ByPassLink.Click();
            Thread.Sleep(2000);
            Sbp.BPSearch.SendKeys(VerifyValue.BPNo);
            Sbp.BtnSave.Click();
            Thread.Sleep(2000);
            Sbp.Yes.Click();
        }
    }
}
