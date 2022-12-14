//using GailSpecFlow.Tests;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using GailSpecFlow.PageObjects;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Commands;
using GailSpecFlow.Tests;
using GailSpecFlow.Properties;

namespace Tests
{
    public class TestSuite : Utility
    {
               
        [Order(0), Test]
        public void setup() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Utility utility = new Utility();
            utility.StartBrowser();
        }

        [Order(1), Test]
        public void Login() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_Login tl = new Test_Login();
            tl.GetLogin();           
        }
        [Order(2), Test]
        public void Dashboard()
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_Dashboard test_Dashboard = new Test_Dashboard();
            test_Dashboard.Menu();           
        }
        [Order(3), Test]
        public void Registration() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_Registration Tr = new Test_Registration();
            Tr.GetRegistration();
        }
        [Order(4), Test]
        public void UploadDoc() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_Upload Tu = new Test_Upload();
            Tu.UploadDoc();                      
        }
        [Order(5), Test]
        public void DocVerification()
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_DocVerify Td = new Test_DocVerify();
            Td.DocVerify();            
        }
        [Order(6), Test]
        public void AssignToAgency() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_ToAgency Tta = new Test_ToAgency();
            Tta.ToAgency();            
        }
        [Order(7), Test]
        public void AssignByAgency()
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_ByAgency Tba = new Test_ByAgency();
            Tba.AssignByAgency();
        }
        [Order(8), Test]
        public void Feasibility() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_Feasibility Tf = new Test_Feasibility();
            Tf.Checkfeasibility();
        }
        [Order(9), Test]
        public void MeterAndGIInstallation() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_MeterGI Tmg = new Test_MeterGI();
            Tmg.MeterIntallation();
            Tmg.GIInstallation();
        }
        [Order(10), Test]
        public void RFC() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_RFCDone Tr = new Test_RFCDone();
            Tr.RFCDone();
        }
        [Order(11), Test]
        public void SDByPass() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_SDByPass Tsbp = new Test_SDByPass();
            Tsbp.SDByPassMoveIn();
        }
        [Order(12), Test]
        public void GasInDone() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_GasIn Tg = new Test_GasIn();
            Tg.GasIn();
        }
        [Order(13), Test]
        public void GasInApproval()
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_GasInApprove Tga = new Test_GasInApprove();
            Tga.GasInApprove();
        }
        [Order(14), Test]
        public void MROGeneration() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_MRO Tm = new Test_MRO();
            Tm.MRO();
        }
        [Order(15), Test]
        public void MeterReading() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_MeterReading Tmr = new Test_MeterReading();
            Tmr.DoMeterReading();
        }
        [Order(16), Test]
        public void InvoiceGeneration() 
        {
            TestReport = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            Test_Invoice Ti = new Test_Invoice();
            Ti.Invoice();
        }
    }
}
