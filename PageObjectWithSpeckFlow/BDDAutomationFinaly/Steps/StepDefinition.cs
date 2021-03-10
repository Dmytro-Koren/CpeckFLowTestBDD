using BDDAutomationFinaly.Base;
using BDDAutomationFinaly.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDAutomationFinaly.Steps
{
    [Binding]
    public sealed class StepDefinition
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public StepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I open official SpecFlow web site")]
        public void OpenOfficialSpecFlowWebSite()
        {
            HomePage.Instance.OpenSpecFlowHomePage();
        }

        [When(@"I hover the '(.*)' menu item from the main menu")]
        public void HoverTheMenuItemFromTheMainMenu(string menuItem)
        {
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"I click '(.*)' option from the main menu")]
        public void ClickOptionFromTheMainMenu(string options)
        {
            HomePage.Instance.ClicSubMenuItem(options);
        }

        [When(@"I click on searchField field")]
        public void ClickOnFieldSearch ()
        {
            //DriverManager.DriverWait(14);
            DocsSpecFlowPage.Instance.ClickONSearchFieald();
        }

        [When(@"I input '(.*)' text to input field")]
        public void InputTextToSearch(string inputText)
        {
            // DriverManager.DriverWait(14);
            DocsSpecFlowPage.Instance.INputTextToSearchMenu(inputText);
        }


        [When(@"I click to '(.*)' result")]
        public void ClickToResultInSearch(string searchResult)
        {
            //DriverManager.DriverWait(14);
            DocsSpecFlowPage.Instance.ClickONSearchResultFieald(searchResult);
           
        }

        [Then(@"Page with '(.*)' title should be the same that search request")]
        public void PageWithTitleShouldBeTheSameThatSearchRequest(string title)
        {
            Assert.IsTrue(BasePage.Instance.IsPageTitleDisplayed(title), "Page title for the page is not displayed");
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}


