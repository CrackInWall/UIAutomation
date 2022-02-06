using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class PageObjects : HelperClass
    {
        public By loginNameBy = By.Name("email");
        public By loginPasswordBy = By.Name("password");
        public By loginButtonBy = By.XPath("//button//span[contains(text(), 'Login')]");
        public IWebElement loginName => Driver.FindElement(loginNameBy);
        public IWebElement loginPassword => Driver.FindElement(loginPasswordBy);
        public IWebElement loginButton => Driver.FindElement(loginButtonBy);


        public void LoginTo()
        {            
            Driver.Navigate().GoToUrl(url);
            WaitUntilelementIsPresent(loginNameBy);
            loginName.SendKeys("user@phptravels.com");
            WaitUntilelementIsPresent(loginPasswordBy);
            loginPassword.SendKeys("demouser");
            WaitUntilelementIsPresent(loginButtonBy);
            loginButton.Click();
            Thread.Sleep(6000);
        }
    }
}
