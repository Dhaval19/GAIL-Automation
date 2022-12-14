using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_ByAgency
    {
        ByAgencyPage Byp = new ByAgencyPage();
        DashboardPage Dp = new DashboardPage();
        ByAgencyValue Bav = new ByAgencyValue();
        public void AssignByAgency() 
        {
            Thread.Sleep(2000);  
            Dp.Onboarding.Click();
            Byp.ByAgencyLink.Click();
            Thread.Sleep(2000);
            Methods.Dropdown(Byp.Agency,Bav.Agency);
            Byp.BPSearch.SendKeys(VerifyValue.BPNo);    
            Byp.BtnSearch.Click();
            Thread.Sleep(2000);
            Byp.SelectAll.Click();
            Methods.Dropdown(Byp.Supervisor,Bav.Supervisor);
            Byp.BtnAssign.Click();
            Thread.Sleep(3000);
            Byp.Yes.Click();
        }
    }
}
