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
        private string username = "user@phptravels.com";
        private string password = "demouser";
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
            Write(loginName, username);            
            WaitUntilelementIsPresent(loginPasswordBy);
            Write(loginPassword, password);
            WaitUntilelementIsPresent(loginButtonBy);
            ClickOn(loginButton);
            Thread.Sleep(6000);
        }
    }
}
