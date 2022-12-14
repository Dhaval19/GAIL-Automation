using GailSpecFlow;
using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace Tests
{
    public class Test_Registration
    {
        RegistrationPage Rp = new RegistrationPage();
        public void GetRegistration() 
        {
            Thread.Sleep(3000);
            Methods.Wait(Rp.RegLink);
            Rp.RegLink.Click();
            Thread.Sleep(1000);
            Rp.Fname.SendKeys(RegValue.Username);
            Rp.Mname.SendKeys(RegValue.Mname);
            Rp.HouseNo.SendKeys(RegValue.HouseNo);
            Rp.Society.SendKeys(RegValue.Society);
            Rp.street.SendKeys(RegValue.street);
            Rp.Pincode.SendKeys(RegValue.Pincode);
            Rp.Mno.SendKeys(RegValue.Mno);
            Rp.Email.SendKeys(RegValue.Email);
            Methods.Dropdown(Rp.TypeOfHouse, RegValue.TypeOfHouse);
            Methods.Dropdown(Rp.Floor, RegValue.Floor);
            Methods.Dropdown(Rp.Area, RegValue.Area);
            Rp.Save.Click();
            Thread.Sleep(2000);
            Methods.GetAppNo();
            Console.WriteLine(RegValue.AppNo);
            Rp.Yes.Click();
            Thread.Sleep(1000);
        }
    }
}
