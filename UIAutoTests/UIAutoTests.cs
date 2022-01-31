using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class UIAutoTests
    {
        [Fact]
        public void Login()
        {
            var user = new HelperClass();
            user.Setup();
            user.LoginTo();
            user.CloseBrowser();
        }
    }
}
