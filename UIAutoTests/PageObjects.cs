using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class PageObjects : DriverHelper
    {
        public By loginNameBy = By.Name("username");
        public By loginPasswordBy = By.Name("password");
        public By loginButtonBy = By.XPath("//input[@class='button']");
        public IWebElement loginName => Driver.FindElement(loginNameBy);
        public IWebElement loginPassword => Driver.FindElement(loginPasswordBy);
        public IWebElement loginButton => Driver.FindElement(loginButtonBy);


    }
}
