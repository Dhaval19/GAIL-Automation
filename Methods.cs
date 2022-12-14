using AngleSharp.Text;
using GailSpecFlow.PageObjects;
using GailSpecFlow.Properties;
//using OpenQA.Selenium.DevTools.V105.CSS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow 

{
    public class Methods
    {
        public static void Dropdown(IWebElement Element,string Value)
        {
            SelectElement Se = new SelectElement(Element);
            Se.SelectByValue(Value);
        }
        public static void Wait(IWebElement Ele) 
        {
            WebDriverWait wait = new WebDriverWait(PropertyCollection.driver, TimeSpan.FromSeconds(8000));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Ele));
        }
        public static void GetAppNo()
        {
            PropertyCollection.driver.FindElement(By.XPath("/html/body/div[5]")).Click();
            string AppN = PropertyCollection.driver.FindElement(By.XPath("/html/body/div[5]/h2")).Text;         
            RegValue.AppNo = AppN.Remove(0, 27);
            RegValue.AppNo.Trim();            
        }
        public static void GetBPNo()
        {
            PropertyCollection.driver.FindElement(By.XPath("/html/body/div[5]/p")).Click();
            string BPN = PropertyCollection.driver.FindElement(By.XPath("/html/body/div[5]/p")).Text;
            VerifyValue.BPNo = BPN.Remove(0,18);
            VerifyValue.BPNo.Trim();
        }
        public static void MROValidation() 
        {
            MROPage Mp = new MROPage();
            do
            {
                Thread.Sleep(5000);
                PropertyCollection.driver.Navigate().Refresh();
            }
            while (Mp.Status.Text != "Completed");
            if (Mp.Status.Text == "Completed" && Mp.Succeed.Text == "1")
            {
                Assert.Pass();
            }
            else if (Mp.Status.Text == "Completed" && Mp.Succeed.Text == "0")
            {
                Thread.Sleep(3000);
                Assert.Fail("MRO Skipped");
            }
        }
        public static int GetCurrentReading() 
        {
            MeterReadingValue Mrv = new MeterReadingValue();
            MeterReadingPage Mp = new MeterReadingPage();
            int pr = Convert.ToInt32(Mp.PrevReading.GetAttribute("value"));
            int cr = pr + 50;
            return cr;
        }
    }
}
