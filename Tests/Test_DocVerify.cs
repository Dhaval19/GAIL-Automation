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
    public class Test_DocVerify
    {        
        DocVerifyPage Dvp = new DocVerifyPage();
        public void DocVerify() 
        {
            Thread.Sleep(1000);            
            Dvp.VerifyLink.Click();
            Dvp.Appno.SendKeys(RegValue.AppNo);
            Dvp.Submit.Click();
            Thread.Sleep(1000);
            Dvp.Verify.Click();
            Thread.Sleep(2000);
            Dvp.Yes.Click();
            Thread.Sleep(3000);
            Methods.GetBPNo();
            Dvp.PopupYes.Click();
            Console.WriteLine(VerifyValue.BPNo);
        }        
    }
}
