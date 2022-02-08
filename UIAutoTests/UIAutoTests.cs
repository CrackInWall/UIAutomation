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
        public static async Task Login()
        {
            var user = new PageObjects();
            user.Setup();
            await PageObjects.LoginTo();
            user.CloseBrowser();
        }
    }
}
