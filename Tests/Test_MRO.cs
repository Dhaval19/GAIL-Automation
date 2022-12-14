using AventStack.ExtentReports;
using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
//using OpenQA.Selenium.DevTools.V105.Animation;
//using OpenQA.Selenium.DevTools.V105.CSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace GailSpecFlow.Tests 
{
    public class Test_MRO : Utility
    {
        MROPage Mp = new MROPage();
        DashboardPage Dp = new DashboardPage();
        //string St;
        public void MRO()
        {
            Thread.Sleep(3000);
            Dp.Billing.Click();
            Thread.Sleep(2000);
            Mp.MROLink.Click();
            Thread.Sleep(3000);
            Mp.BPSearch.SendKeys(VerifyValue.BPNo);
            Mp.MRU.Click();
            Mp.BtnSave.Click();
            Methods.MROValidation();
            Console.WriteLine("Test");
        }
    }
}
