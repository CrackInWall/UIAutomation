using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class UIAutoTests
    {
        [Fact]
        public void Test1()
        {
            var user = new HelperClass();
            user.Setup();
            user.LoginTo();
            user.CloseBrowser();
        }
    }
}
