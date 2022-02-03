using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject5;
using Xunit;
using TestProject5.Page_Object_Model;
namespace TestProject5
{
    [Binding]
    public class SearchTheMedicineSteps : BaseTestSettings
    {
        private Homepage _homepage;
        private ResultPage _resultPage;
        private ProductCategoriesPage _productCategories;
        private BlogPage _blogPage;

        [Given(@"user is on the homepage")]
        public void GivenUserIsOnTheHomepage()
        {
           DriverHolder.chrome = StartDriverWithURL("https://biotus.ua");
            _homepage = new Homepage();
        }
        
        [When(@"user clicks on search field")]
        public void WhenUserClicksOnSearchField()
        {
            _homepage.SearchFieldClick();
        }
        
        [When(@"user enters the search query ""(.*)"" in the search field")]
        public void WhenUserEntersTheSearchQueryInTheSearchField(string p0)
        {
            _homepage.SearchFieldSendKeys(p0);
        }
        
        [When(@"user clicks Enter on the keyboard")]
        public void WhenUserClicksEnterOnTheKeyboard()
        {
            _homepage.SearchFieldSubmit();
            _resultPage = new ResultPage();
        }
        
        [When(@"user clicks on the Categories drop-down menu")]
        public void WhenUserClicksOnTheDrop_DownMenu()
        {
            _homepage.DropDownClick();
        }
        
        [When(@"user clicks on the Vitamins by symptoms category")]
        public void WhenUserClicksOnTheCategory()
        {
            _homepage.DropDownCategoryClick();
            _productCategories = new ProductCategoriesPage();
        }
        
        [When(@"user clicks on the Vitamins for stress subcategory")]
        public void WhenUserClicksOnTheSubcategory()
        {
            _productCategories.VitaminsForStressClick();
            _resultPage = new ResultPage();
        }

        [When(@"user clicks on the In stock filter")]
        public void WhenUserClicksOnTheDiscountFilter()
        {
            _resultPage.InStockFilterClick();
        }

        [When(@"user clicks on the AB PRO NUTRITION manufacturer filter")]
        public void WhenUserClicksOnTheNutricologyManufacturerFilter()
        {
            _resultPage.ManufacturerFilterClick();
        }

        [When(@"user clicks on Blog link")]
        public void WhenUserClicksOnLink()
        {
            _homepage.BlogClick();
            _blogPage = new BlogPage();
        }

        [Then(@"user is on the search result page")]
        public void ThenUserIsOnTheSearchResultPage()
        {
            Assert.Equal("РЕЗУЛЬТАТИ ПОШУКУ: 'ВИТАМИН B6'", _resultPage.GetPageTitleText());
        }
        
        [Then(@"user is on the page with subcategories from the chosen category")]
        public void ThenUserIsOnThePageWithSubcategoriesFromTheChosenCategory()
        {
            Assert.Equal("ВІТАМІНИ ЗА СИМПТОМАМИ", _productCategories.GetPageTitleText());
        }
        
        [Then(@"user is on the page with the products from the chosen subcategory")]
        public void ThenUserIsOnThePageWithTheProductsFromTheChosenSubcategory()
        {
            System.Threading.Thread.Sleep(4000);
            Assert.Equal("ВІТАМІНИ ВІД СТРЕСУ", _resultPage.GetPageTitleText());
        }

        [Then(@"user is on the page with the products chosen by filters")]
        public void ThenUserIsOnThePageWithTheProductsChosenByFilters()
        {
            Assert.Equal("L-триптофан Магний Витамин B6, L-Tryptophan Mg B6, AB PRO Nutrition, антистресс комплекс, 60 капсул", _resultPage.GetFirstProductInFilterText());
        }

        [Then(@"user is o the blog page")]
        public void ThenUserIsOTheBlogPage()
        {
            Assert.Equal("Блог, новости и статьи о витаминах - Biotus", _blogPage.GetPageTitleText());
        }

    }
}
