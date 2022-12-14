using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_Feasibility
    {
        FeasibilityPage Fp = new FeasibilityPage();
        DashboardPage Dp = new DashboardPage();
        FeasibleValue Fv = new FeasibleValue();
        public void Checkfeasibility() 
        {
            Thread.Sleep(2000);
            Dp.Onboarding.Click();
            Thread.Sleep(2000);
            Fp.FeasibileLink.Click();
            Fp.BPSearch.SendKeys(VerifyValue.BPNo);
            Fp.BtnSearch.Click();
            Thread.Sleep(1000);
            Fp.BtnAdd.Click();
            Thread.Sleep(1000);
            Fp.Piping.SendKeys(Fv.PipingValue);
            Fp.SavePiping.Click();
            Thread.Sleep(3000);
        }
    }
}
