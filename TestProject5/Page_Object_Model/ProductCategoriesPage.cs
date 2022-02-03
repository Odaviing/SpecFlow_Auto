using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject5.Page_Object_Model
{
    class ProductCategoriesPage : BaseTestSettings
    {
        public ProductCategoriesPage()
        {
            _driver = DriverHolder.chrome;
        }

        private By _vitaminsForStressLink = By.XPath("//li[26]/div/a/span");
        private By _pageTitle = By.XPath("//h1");

        public void VitaminsForStressClick()
        {
            DriverHolder.chrome.FindElement(_vitaminsForStressLink).Click();
        }

        public string GetPageTitleText()
        {
            return DriverHolder.chrome.FindElement(_pageTitle).Text;
        }
    }
}
