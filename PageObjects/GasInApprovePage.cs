using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class GasInApprovePage
    {
        public GasInApprovePage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='JMR & Gas-In Approval Pending']")]
        public IWebElement ApproveLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[13]/button[1]")]
        public IWebElement BtnJMRAdd;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSave9']")]
        public IWebElement BtnApprove;
    }
}
