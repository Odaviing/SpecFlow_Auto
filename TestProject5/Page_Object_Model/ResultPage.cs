using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject5.Page_Object_Model
{
    class ResultPage : BaseTestSettings
    {
        public ResultPage()
        {
            _driver = DriverHolder.chrome;
        }

        private By _inStockFilter = By.XPath("//dl[@id='narrow-by-list']/div[3]/dd/form/ol/li");
        private By _manufacturerFilter = By.XPath("//dl[@id='narrow-by-list']/div[4]/dd/ol/li/div/div[2]/form/ol/li[2]/a/span");
        private By _firstProduct = By.XPath("//img[@alt='Магний и витамин В6, Magnesium with Vitamin B6, Biotus, 30 таблеток']");
        private By _secondProduct = By.XPath("//img[@alt='Магний и витамин В6, Magnesium with Vitamin B6, Biotus, экстра сильный, 100 капсул']");
        private By _firstProductCompareButton = By.CssSelector(".item:nth-child(1) .link-compare > svg");
        private By _secondProductCompareButton = By.CssSelector(".item:nth-child(2) .link-compare > svg");
        private By _comparisonPageButton = By.CssSelector("a[href='https://biotus.ua/ua/catalog/product_compare/']");
        private By _pageTitle = By.XPath("//h1");
        private By _firstProductInFilter = By.LinkText("L-триптофан Магний Витамин B6, L-Tryptophan Mg B6, AB PRO Nutrition, антистресс комплекс, 60 капсул");

        public void InStockFilterClick()
        {
            System.Threading.Thread.Sleep(3000);
            DriverHolder.chrome.FindElement(_inStockFilter).Click();
        }

        public void ManufacturerFilterClick()
        {
            System.Threading.Thread.Sleep(3000);
            DriverHolder.chrome.FindElement(_manufacturerFilter).Click();
        }

        public void FirstProductFind()
        {
            Actions act = new Actions(DriverHolder.chrome);
            IWebElement elem = DriverHolder.chrome.FindElement(_firstProduct);
            System.Threading.Thread.Sleep(2000);
            act.MoveToElement(elem).Perform();
        }

        public void SecondProductFind()
        {
            Actions act = new Actions(DriverHolder.chrome);
            IWebElement elem = DriverHolder.chrome.FindElement(_secondProduct);
            System.Threading.Thread.Sleep(2000);
            act.MoveToElement(elem).Perform();
        }

        public void FirstProductCompareClick()
        {
            DriverHolder.chrome.FindElement(_firstProductCompareButton).Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void SecondProductCompareClick()
        {
            DriverHolder.chrome.FindElement(_secondProductCompareButton).Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void ComparisonPageClick()
        {
            DriverHolder.chrome.FindElement(_comparisonPageButton).Click();
            System.Threading.Thread.Sleep(2000);
        }

        public string GetPageTitleText()
        {
            return DriverHolder.chrome.FindElement(_pageTitle).Text;
        }

        public string GetFirstProductInFilterText()
        {
            return DriverHolder.chrome.FindElement(_firstProductInFilter).Text;
        }
    }
}
