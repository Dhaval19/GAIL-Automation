using GailSpecFlow.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class Test3_DashboardStepDefinitions : DashboardPage
    {
        [Given(@"Dasboard Is Loaded")]
        public void GivenDasboardIsLoaded()
        {
            PropertyCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Then(@"Verify On Boarding Link")]
        public void ThenVerifyOnBoardingLink()
        {
            Console.WriteLine(Onboarding.Text);
        }

        [Then(@"Verify Billing Link")]
        public void ThenVerifyBillingLink()
        {
            Console.WriteLine(Billing.Text);
        }
    }
}
