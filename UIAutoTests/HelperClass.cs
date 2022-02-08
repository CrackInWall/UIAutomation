using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading.Tasks;

namespace UIAutoTests
{
    public class HelperClass : DriverHelper
    {
        //public string url = "https://parabank.parasoft.com/";
        public static string url = "https://www.phptravels.net/login";        

        public void Setup()
        {            
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");

            Driver.Manage().Window.Maximize();
        }        
        public void CloseBrowser()
        {
            Driver.Close();
        }
        public void WaitUntilelementIsPresent(By el)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            WebElement element = (WebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(el));            
        }
        //public void ClickOn(IWebElement element)
        //{
        //    element.Click();
        //}
        public static async Task ClickOn(IWebElement element)
        {
            await Task.Run(() => element.Click());
        }
        //public void Write(IWebElement element, string text)
        //{
        //    element.SendKeys(text);           
        //}
        public static async Task Write(IWebElement element, string text)
        {
            await Task.Run(() => element.SendKeys(text));
        }
    }
}
