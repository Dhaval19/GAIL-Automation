using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
using System.Diagnostics;
using OpenQA.Selenium.DevTools.V107.IndexedDB;
using System.Data;
using Tests;

namespace GailSpecFlow.Tests
{
    public class Test_Upload       
    {
        IWebDriver driver = Properties.PropertyCollection.driver;
        DashboardPage Dp = new DashboardPage();
        UploadPage Up = new UploadPage();
        public void UploadDoc() 
        {
            driver.SwitchTo().NewWindow(WindowType.Tab);
            var tabs2 = driver.WindowHandles;
            var lt = tabs2.Last();
            var ft = tabs2.First();
            driver.SwitchTo().Window(lt);
            driver.Close();
            driver.SwitchTo().Window(ft);           
            Thread.Sleep(2000);
            Methods.Wait(Dp.Onboarding);
            Dp.Onboarding.Click();
            Thread.Sleep(2000);
            Up.UpLink.Click();
            Up.AppNo.SendKeys(RegValue.AppNo);
            Thread.Sleep(4000);
            Up.BtnSearch.Click();
            Thread.Sleep(2000);
            // Uploading Images
            Up.Doc1.SendKeys(UploadValue.UpImg);
            Up.Doc2.SendKeys(UploadValue.UpImg);
            Up.BtnSave.Click();
            Thread.Sleep(5000);
            Up.OnBoarding.Click();
        }
    }
}
