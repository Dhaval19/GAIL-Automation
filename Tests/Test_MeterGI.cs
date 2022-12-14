using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_MeterGI
    {
        MeterGIPage Mgp = new MeterGIPage();
        MeterGIValue Mgv = new MeterGIValue();
        DashboardPage Dp = new DashboardPage();
        public void MeterIntallation() 
        {
            Thread.Sleep(5000);
            Dp.Onboarding.Click();
            Thread.Sleep(3000);
            Mgp.MeterLink.Click();
            Mgp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mgp.BtnSearch.Click();
            Thread.Sleep(3000);
            Mgp.BtnAdd.Click();
            Thread.Sleep(2000);
            Methods.Dropdown(Mgp.DDMeterMake,Mgv.MeterMake);
            Mgp.MeterNo.SendKeys(Mgv.MeterNo);
            Mgp.SwitchOnDate.SendKeys(Mgv.MeterDate);
            Mgp.BtnSave.Click();
        }
        public void GIInstallation() 
        {
            Thread.Sleep(3000);
            Mgp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mgp.BtnSearch.Click();
            Thread.Sleep(3000);
            Mgp.BtnGi.Click();
            Thread.Sleep(2000);
            //Mgp.GiPiping.Click();
            Mgp.BtnGiSave.Click();
        }
    }
}
