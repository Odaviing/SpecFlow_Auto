using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using TestProject5;
using Xunit;
using TestProject5.Page_Object_Model;

namespace TestProject5
{
    [Binding]
    public class CompareProductsSteps : BaseTestSettings
    {
        private Homepage _homepage;
        private ResultPage _resultPage;
        private BlogPage _blogPage;
        private ComparisonPage _comparisonPage;

        [Given(@"user is on the Homepage")]
        public void GivenUserIsOnTheHomepage()
        {
            DriverHolder.chrome = StartDriverWithURL("https://biotus.ua");
            _homepage = new Homepage();
        }

        [When(@"user clicks on Search field")]
        public void WhenUserClicksOnSearchField()
        {
            _homepage.SearchFieldClick();
        }

        [When(@"user enters the Search Query ""(.*)"" in the search field")]
        public void WhenUserEntersTheSearchQueryInTheSearchField(string p0)
        {
            _homepage.SearchFieldSendKeys(p0);
        }

        [When(@"user clicks Enter key on the keyboard")]
        public void WhenUserClicksEnterOnTheKeyboard()
        {
            _homepage.SearchFieldSubmit();
            _resultPage = new ResultPage();
        }

        [When(@"user clicks on the add to comparison button on the first vitamin on the page")]
        public void WhenUserClicksOnTheButtonOnTheFirstVitaminOnThePage()
        {
            _resultPage.FirstProductFind();
            _resultPage.FirstProductCompareClick();
        }
        
        [When(@"user clicks on the add to comparison button on the second vitamin on the page")]
        public void WhenUserClicksOnTheButtonOnTheSecondVitaminOnThePage()
        {
            _resultPage.SecondProductFind();
            _resultPage.SecondProductCompareClick();
        }
        
        [When(@"user clicks on the button with scales icon")]
        public void WhenUserClicksOnTheButtonWithScalesIcon()
        {
            _resultPage.ComparisonPageClick();
            _comparisonPage = new ComparisonPage();
            
        }
        
        [When(@"user clicks on the Comparison Only button")]
        public void WhenUserClicksOnTheButton()
        {
            _comparisonPage.ComparisonOnlyClick();
        }
        
        [When(@"user clicks on the button with the X icon on the first vitamin in the comparison list")]
        public void WhenUserClicksOnTheButtonWithTheXIconOnTheFirstVitaminInTheComparisonList()
        {
            _comparisonPage.FirstProductFind();
            _comparisonPage.FirstProductDelete();
        }

        [When(@"user clicks on the Vitamins category button")]
        public void WhenUserClicksOnTheВитаминыCategoryButton()
        {
            _blogPage.VitaminsCategoryClick();
        }

        [When(@"user clicks on Blog Link")]
        public void WhenUserClicksOnLink()
        {
            _homepage.BlogClick();
            _blogPage = new BlogPage();
        }

        [Then(@"user is on the Search result page")]
        public void ThenUserIsOnTheSearchResultPage()
        {
            Assert.Equal("РЕЗУЛЬТАТИ ПОШУКУ: 'ВИТАМИН B6'", _resultPage.GetPageTitleText());
        }

        [Then(@"user is on the page with the comparison of the chosen products")]
        public void ThenUserIsOnThePageWithTheComparisonOfTheChosenProducts()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.Equal("ПОРІВНЯТИ ТОВАРИ", _comparisonPage.GetPageTitleText());
        }
        
        [Then(@"user sees only differences between chosen products in the parametrs table")]
        public void ThenUserSeesOnlyDifferencesBetweenChosenProductsInTheParametrsTable()
        {
            Assert.Equal("100 шт.", _comparisonPage.GetFirstProductPropertyText());
            Assert.Equal("30 шт.", _comparisonPage.GetSecondProductPropertyText());
        }
        
        [Then(@"user sees changed list of comparisons")]
        public void ThenUserSeesChangedListOfComparisons()
        {
            Assert.Equal("30 шт.", _comparisonPage.GetFirstProductPropertyText());
        }

        [Then(@"user is on the page with the articles from the chosen category")]
        public void ThenUserIsOnThePageWithTheArticlesFromTheChosenCategory()
        {
            Assert.Equal("Витамины", _blogPage.GetBreadCrumbsText());
        }

        [Then(@"user is on the blog page")]
        public void ThenUserIsOTheBlogPage()
        {
            Assert.Equal("Блог, новости и статьи о витаминах - Biotus", _blogPage.GetPageTitleText());
        }
    }
}
