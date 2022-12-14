using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class ByAgencyPage
    {
        public ByAgencyPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='BP Number Assignment For Feasibility By Agency']")]
        public IWebElement ByAgencyLink;

        // Dropdwon value = 44
        [FindsBy(How = How.XPath, Using = "//select[@id='AgencyId']")]
        public IWebElement Agency;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        // Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@id='SelectAll']")]
        public IWebElement SelectAll;

        // Dropdown Value = 10228
        [FindsBy(How = How.XPath, Using = "//select[@id='SupervisorId']")]
        public IWebElement Supervisor;       

        [FindsBy(How = How.XPath, Using = "//button[@id='btnAssignSuperUser']")]
        public IWebElement BtnAssign;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Yes!')]")]
        public IWebElement Yes;
    }
}
