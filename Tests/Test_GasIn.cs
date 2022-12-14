using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_GasIn
    {
        GasInPage Gp = new GasInPage();
        GasInValue Gv = new GasInValue();
        DashboardPage Dp = new DashboardPage();
        public void GasIn() 
        {
            Thread.Sleep(3000);
            Dp.Onboarding.Click();
            Thread.Sleep(2000);
            Gp.GasInLink.Click();
            Thread.Sleep(2000);
            Gp.BPSearch.SendKeys(VerifyValue.BPNo);
            Gp.BtnSearch.Click();
            Thread.Sleep(2000);
            Gp.BtnAdd.Click();
            Thread.Sleep(2000);
            Gp.JMRDate.SendKeys(Gv.JMRDate);
            Methods.Dropdown(Gp.DDMRU,Gv.MRUID);
            Thread.Sleep(1000);
            Gp.JMRFile.SendKeys(Gv.JMRFile);
            Thread.Sleep(2000);
            Gp.BtnSave.Click();
        }
    }
}
