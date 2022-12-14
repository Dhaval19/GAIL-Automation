using GailSpecFlow.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Test4_RegistrationStepDefinitions : DashboardPage
    {
        RegistrationPage Rp = new RegistrationPage();
        [Given(@"Page Is Loaded")]
        public void GivenPageIsLoaded()
        {
            Thread.Sleep(3000);
            Onboarding.Click();
        }

        [Then(@"Fill The Form")]
        public void ThenFillTheForm()
        {
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
        }

        [Then(@"Save The Form")]
        public void ThenSaveTheForm()
        {
            Rp.Save.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Get The Application No")]
        public void ThenGetTheApplicationNo()
        {
            Methods.GetAppNo();
            Console.WriteLine(RegValue.AppNo);
            Rp.Yes.Click();
            Thread.Sleep(1000);
        }
    }
}
