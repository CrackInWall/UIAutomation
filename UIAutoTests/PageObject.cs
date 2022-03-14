using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomation
{
    public static class PageObject
    {
        private static string Username = "user@phptravels.com";
        private static string Password = "demouser";
        public static By LoginNameBy = By.Name("email");
        public static By LoginPasswordBy = By.Name("password");
        public static By LoginButtonBy = By.XPath("//button//span[contains(text(), 'Login')]");
        public static IWebElement LoginName => HelperClass.Driver.FindElement(LoginNameBy);
        public static IWebElement LoginPassword => HelperClass.Driver.FindElement(LoginPasswordBy);
        public static IWebElement LoginButton => HelperClass.Driver.FindElement(LoginButtonBy);


        public async static Task LoginTo()
        {
            HelperClass.Driver.Navigate().GoToUrl(HelperClass.Url);
            await HelperClass.FillIn(LoginName, Username);
            await HelperClass.FillIn(LoginPassword, Password);
            await HelperClass.ClickOn(LoginButton);
            Thread.Sleep(1000);
        }
        public async static Task Logout()
        {
            //Add code here
        }
    }
}
