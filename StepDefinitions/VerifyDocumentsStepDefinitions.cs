using GailSpecFlow.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class VerifyDocumentsStepDefinitions : DashboardPage
    {
        DocVerifyPage Dvp = new DocVerifyPage();
        [Given(@"When Page Is Loaded")]
        public void GivenWhenPageIsLoaded()
        {
            Thread.Sleep(1000);
            Dvp.VerifyLink.Click();
        }

        [Then(@"Search Record By App No")]
        public void ThenSearchRecordByAppNo()
        {
            Dvp.Appno.SendKeys(RegValue.AppNo);
            Dvp.Submit.Click();
            Thread.Sleep(1000);
        }

        [Then(@"Click On Verify Button")]
        public void ThenClickOnVerifyButton()
        {
            Dvp.Verify.Click();
            Thread.Sleep(2000);
            Dvp.Yes.Click();
            Thread.Sleep(3000);
        }

        [Then(@"Get Generated BP Number")]
        public void ThenGetGeneratedBPNumber()
        {
            Methods.GetBPNo();
            Dvp.PopupYes.Click();
            Console.WriteLine(VerifyValue.BPNo);
        }
    }
}
