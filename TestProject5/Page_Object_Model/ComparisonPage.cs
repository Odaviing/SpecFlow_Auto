using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject5.Page_Object_Model
{
    class ComparisonPage : BaseTestSettings
    {
        public ComparisonPage()
        {
            _driver = DriverHolder.chrome;
        }

        private By _comparisonOnlyButton = By.XPath("//table[@id='product-comparison']/tbody/tr/th/div/label/span");
        private By _firstProduct = By.XPath("//span/img");
        private By _deleteButton = By.XPath("//table[@id='product-comparison']/tbody/tr/td/div/form/button");
        private By _pageTitle = By.XPath("//h1");
        private By _firstProductProperty = By.XPath("//table[@id='product-comparison']/tbody[2]/tr[2]/td/div");
        private By _secondProductProperty = By.XPath("//table[@id='product-comparison']/tbody[2]/tr[2]/td[2]/div");

        public void ComparisonOnlyClick()
        {
            DriverHolder.chrome.FindElement(_comparisonOnlyButton).Click();
        }

        public void FirstProductFind()
        {
            Actions act = new Actions(DriverHolder.chrome);
            IWebElement elem = DriverHolder.chrome.FindElement(_firstProduct);
            System.Threading.Thread.Sleep(2000);
            act.MoveToElement(elem).Perform();
        }

        public void FirstProductDelete()
        {
            DriverHolder.chrome.FindElement(_deleteButton).Click();
        }

        public string GetPageTitleText()
        {
            return DriverHolder.chrome.FindElement(_pageTitle).Text;
        }

        public string GetFirstProductPropertyText()
        {
            return DriverHolder.chrome.FindElement(_firstProductProperty).Text;
        }

        public string GetSecondProductPropertyText()
        {
            return DriverHolder.chrome.FindElement(_secondProductProperty).Text;
        }
    }
}
