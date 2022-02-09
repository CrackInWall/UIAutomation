using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace UIAutoTests
{
    public class UIAutoTests
    {
        [Fact]
        public void Login()
        {
            var user = new PageObjects();
            user.Setup();
            user.LoginTo();
            user.CloseBrowser();
        }
    }
}
