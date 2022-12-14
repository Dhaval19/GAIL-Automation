using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class FeasibilityPage
    {
        public FeasibilityPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Feasibility And Extra Piping Estimation']")]
        public IWebElement FeasibileLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='filter']")]
        public IWebElement BPSearch;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Add']")]
        public IWebElement BtnAdd;

        [FindsBy(How = How.XPath, Using = "//input[@id='Pipinginmeter']")]
        public IWebElement Piping;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnpipingSave']")]
        public IWebElement SavePiping; 

    }
}
