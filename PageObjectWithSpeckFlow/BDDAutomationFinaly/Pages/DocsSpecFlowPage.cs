using OpenQA.Selenium;
using System.Linq;

namespace BDDAutomationFinaly.Pages
{
    class DocsSpecFlowPage : BasePage
    {
        private string SearсhFieldItemXpath => "//form[@id = 'rtd-search-form']";

        private string InputTextToSearchXpath => "//input[@class = 'search__outer__input']";

        private string SearchRequestWorld => "//span[@class= 'search__result__subheading']";

        private static DocsSpecFlowPage docsPage;

        public static DocsSpecFlowPage Instance => docsPage ?? (docsPage = new DocsSpecFlowPage());


        public void ClickONSearchFieald()
        {
            var searchField = FindElement(By.XPath(SearсhFieldItemXpath));
            searchField.Click();
        }

        public void INputTextToSearchMenu(string text)
        {
            var subMenuItem = FindElement(By.XPath(InputTextToSearchXpath));
            subMenuItem.SendKeys(text);
        }

        public void ClickONSearchResultFieald(string item)
        {
            var searchField = FindElements(By.XPath(SearchRequestWorld)).First(x => x.Text.Equals(item)); ;
            searchField.Click();
        }
    }
}
