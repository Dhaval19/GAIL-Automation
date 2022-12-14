using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.Tests
{
    public class Test_Invoice
    {
        InvoicePage Ip = new InvoicePage();        
        DashboardPage Dp = new DashboardPage();
        public void Invoice() 
        {
            Thread.Sleep(3000);
            Dp.Billing.Click();
            Thread.Sleep(2000);
            Ip.InvoiceLink.Click();
            Thread.Sleep(3000);
            Ip.FromDate.Click();
            Thread.Sleep(1000);
            Ip.Month.Click();
            Thread.Sleep(1000);
            Ip.JanMonth.Click();
            Thread.Sleep(1000);
            Ip.date.Click();
            Thread.Sleep(1000);
            Ip.BPSearch.SendKeys(VerifyValue.BPNo);
            Thread.Sleep(3000);
            Ip.BtnPrint.Click();
            Thread.Sleep(3000);
            Ip.Yes.Click();
        }
    }
}
