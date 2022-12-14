using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class ToAgencyPage
    {
        public ToAgencyPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='BP Number Assignment For Feasibility To Agency']")]
        public IWebElement ToAgencyLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        // Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@id='SelectAll']")]
        public IWebElement SelectAll;

        // Dropdwon value = 44
        [FindsBy(How = How.XPath, Using = "//select[@id='Agency']")]
        public IWebElement Agency;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnAssign']")]
        public IWebElement BtnAssign;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Yes!')]")]
        public IWebElement Yes;
        
    }
}
