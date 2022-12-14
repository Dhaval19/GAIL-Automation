using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class DocVerifyPage
    {
        public DocVerifyPage()
        {
            PageFactory.InitElements(PropertyCollection.driver,this);
        }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Documents Verification']")]
        public IWebElement VerifyLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement Appno;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement Submit;

        [FindsBy(How = How.XPath, Using = "//tbody/tr/td[8]/button[1]")]
        public IWebElement Verify;

        [FindsBy(How = How.XPath, Using = "//button[@class='confirm']")]
        public IWebElement Yes;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[2]")]
        public IWebElement PopupYes;

    }
}
