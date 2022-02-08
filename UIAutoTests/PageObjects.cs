using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class PageObjects : HelperClass
    {
        private static string username = "user@phptravels.com";
        private static string password = "demouser";
        public static By loginNameBy = By.Name("email");
        public static By loginPasswordBy = By.Name("password");
        public static By loginButtonBy = By.XPath("//button//span[contains(text(), 'Login')]");
        public static IWebElement loginName => Driver.FindElement(loginNameBy);
        public static IWebElement loginPassword => Driver.FindElement(loginPasswordBy);
        public static IWebElement loginButton => Driver.FindElement(loginButtonBy);


        public static async Task LoginTo()
        {            
            Driver.Navigate().GoToUrl(url);
            //WaitUntilelementIsPresent(loginNameBy);
            await Write(loginName, username);            
            //WaitUntilelementIsPresent(loginPasswordBy);
            await Write(loginPassword, password);
            //WaitUntilelementIsPresent(loginButtonBy);
            await ClickOn(loginButton);
            Thread.Sleep(6000);
        }
    }
}
