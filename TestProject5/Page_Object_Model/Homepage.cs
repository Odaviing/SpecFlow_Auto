using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestProject5.Page_Object_Model
{
    class Homepage : BaseTestSettings
    {
        public Homepage()
        {
            _driver = DriverHolder.chrome;
        }

        private By _searchField = By.Id("search");
        private By _dropDown = By.LinkText("Категорії");
        private By _dropDownCategory = By.XPath("//ul[@id='nav']/li/a/span");
        private By _blogLink = By.LinkText("Блог");

        public void SearchFieldClick()
        {
            DriverHolder.chrome.FindElement(_searchField).Click();
        }

        public void SearchFieldSendKeys(string keys)
        {
            DriverHolder.chrome.FindElement(_searchField).SendKeys(keys);
        }

        public void SearchFieldSubmit()
        {
            DriverHolder.chrome.FindElement(_searchField).SendKeys(Keys.Enter);
        }

        public void DropDownClick()
        {
            DriverHolder.chrome.FindElement(_dropDown).Click();
        }

        public void DropDownCategoryClick()
        {
            DriverHolder.chrome.FindElement(_dropDownCategory).Click();
        }

        public void BlogClick()
        {
            DriverHolder.chrome.FindElement(_blogLink).Click();
        }
    }
}
