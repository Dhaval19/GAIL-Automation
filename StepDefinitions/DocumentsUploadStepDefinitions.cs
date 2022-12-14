using GailSpecFlow.PageObjects;
using System;
using System.Runtime.Intrinsics.Arm;
using TechTalk.SpecFlow;

namespace GailSpecFlow.StepDefinitions
{
    [Binding]
    public class DocumentsUploadStepDefinitions : DashboardPage
    {
        IWebDriver driver = Properties.PropertyCollection.driver;
        DocVerifyPage Dvp = new DocVerifyPage();
        UploadPage Up = new UploadPage();
        [Given(@"Verify Page Is loaded")]
        public void GivenVerifyPageIsLoaded()
        {
            driver.SwitchTo().NewWindow(WindowType.Tab);
            var tabs2 = driver.WindowHandles;
            var lt = tabs2.Last();
            var ft = tabs2.First();
            driver.SwitchTo().Window(lt);
            driver.Close();
            driver.SwitchTo().Window(ft);
            Thread.Sleep(2000);
            Methods.Wait(Onboarding);
            Onboarding.Click();
            Thread.Sleep(2000);
            Up.UpLink.Click();
        }

        [Then(@"Search Customer By App No")]
        public void ThenSearchCustomerByAppNo()
        {
            Up.AppNo.SendKeys(RegValue.AppNo);
            Thread.Sleep(4000);
            Up.BtnSearch.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Upload File")]
        public void ThenUploadFile()
        {
            // Uploading Images
            Up.Doc1.SendKeys(UploadValue.UpImg);
            Up.Doc2.SendKeys(UploadValue.UpImg);
        }

        [Then(@"Click On Save Button")]
        public void ThenClickOnSaveButton()
        {
            Up.BtnSave.Click();
            Thread.Sleep(5000);
            Up.OnBoarding.Click();
        }
    }
}
