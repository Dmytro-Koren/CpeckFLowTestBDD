using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BDDAutomationFinaly.Base
{
    public class DriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver Instance()
        {
            if(driver== null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);         
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
