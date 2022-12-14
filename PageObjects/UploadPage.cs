using GailSpecFlow.Properties;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GailSpecFlow.PageObjects
{
    public class UploadPage
    {
        public UploadPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//body/div[@id='wrapper']/div[@id='page-wrapper']/div[2]/nav[1]/div[2]/ul[1]/ul[1]/li[3]/a[1]")]
        public IWebElement UpLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='ApplicationNumber']")]
        public IWebElement AppNo;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnappSearch']")]
        public IWebElement BtnSearch;

        [FindsBy(How = How.XPath, Using = "//div[@id='customIDProof']//div//input[@id='UploadedFile']")]
        public IWebElement Upbtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='UploadedFile1']")]
        public IWebElement Doc1;

        [FindsBy(How = How.XPath, Using = "//input[@id='UploadedFile2']")]
        public IWebElement Doc2;

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSubmit']")]
        public IWebElement BtnSave;

        [FindsBy(How = How.XPath, Using = "//a[@id='menu~Customer On Boarding']")]
        public IWebElement OnBoarding;
        
    }

}
