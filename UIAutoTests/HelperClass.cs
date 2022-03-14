using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading.Tasks;

namespace UIAutomation
{
    public static class HelperClass
    {
        private static IWebDriver driver = new ChromeDriver("C:/Projects/UIAutomation/bin/Debug");
        public static IWebDriver Driver
        {
            get => driver;
            set => driver = value;
        }

        //public string url = "https://parabank.parasoft.com/";
        public const string Url = "https://www.phptravels.net/login";

        public static void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");

            Driver.Manage().Window.Maximize();
        }
        public static void CloseBrowser()
        {
            Driver.Close();
        }
        public static async Task ClickOn(IWebElement element)
        {
            await Task.Run(() => element.Click());
        }
        public static async Task FillIn(IWebElement element, string text)
        {
            await Task.Run(() => element.SendKeys(text));
        }
    }
}
