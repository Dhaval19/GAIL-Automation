using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_ToAgency
    {
        ToAgencyPage Ap = new ToAgencyPage();
        DashboardPage Dp = new DashboardPage();
        ToAgencyValue Av = new ToAgencyValue();
        public void ToAgency() 
        {
            Thread.Sleep(2000);
            //Methods.Wait(Dp.Onboarding);
            Dp.Onboarding.Click();
            Ap.ToAgencyLink.Click();
            Ap.BPSearch.SendKeys(VerifyValue.BPNo);
            Thread.Sleep(2000);
            Ap.BtnSearch.Click();
            Thread.Sleep(2000);
            Ap.SelectAll.Click();
            Methods.Dropdown(Ap.Agency,Av.AgencyId);
            Thread.Sleep(2000);
            Ap.BtnAssign.Click();
            Thread.Sleep(3000);
            Ap.Yes.Click();
        }
    }
}
