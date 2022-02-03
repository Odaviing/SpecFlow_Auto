using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject5.Page_Object_Model
{
    class BlogPage : BaseTestSettings
    {
        public BlogPage()
        {
            _driver = DriverHolder.chrome;
        }

        private By _vitaminsCategory = By.XPath("//a[contains(text(),'Витамины')]");
        private By _pageTitle = By.XPath("//h1");
        private By _breadCrumbs = By.XPath("//strong[contains(.,'Витамины')]");

        public void VitaminsCategoryClick()
        {
            DriverHolder.chrome.FindElement(_vitaminsCategory).Click();
        }

        public string GetPageTitleText()
        {
            return DriverHolder.chrome.FindElement(_pageTitle).Text;
        }

        public string GetBreadCrumbsText()
        {
            return DriverHolder.chrome.FindElement(_breadCrumbs).Text;
        }
    }
}
