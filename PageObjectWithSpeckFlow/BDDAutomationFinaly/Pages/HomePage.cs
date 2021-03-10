using BDDAutomationFinaly.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace BDDAutomationFinaly.Pages
{
    class HomePage : BasePage
    {
        private string URL => "https://specflow.org";
        private string MainMenuItemXpath => "//ul[@id = 'avia-menu']/li/a/span[@class ='avia-menu-text']";
        private string SubMenuItemXpath => "//ul[@class = 'sub-menu']/li/a/span[@class ='avia-menu-text']";
 
        private static HomePage homePage;

        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        public void OpenSpecFlowHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(MainMenuItemXpath)).First(x => x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }

        public void ClicSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(SubMenuItemXpath)).First(x => x.Text.Equals(item));
            subMenuItem.Click();
        }
    }
}
