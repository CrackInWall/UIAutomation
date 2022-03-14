using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UIAutomation
{
    public class TestBase
    {
        [OneTimeSetUp]
        public virtual async Task Login()
        {
            HelperClass.Setup();
            await PageObject.LoginTo();
        }
        [OneTimeTearDown]
        public virtual async Task Logout()
        {
            await PageObject.Logout();         
            HelperClass.CloseBrowser();
        }
        [TearDown]
        public virtual async Task TakeScreenshotIfTestFails()
        {
            Screenshot screenshot = ((ITakesScreenshot)HelperClass.Driver).GetScreenshot();
            
            var filePath = $"C:/Projects/UIAutomation/Screenshots\\{TestContext.CurrentContext.Test.Name}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
            var path = $"C:/Projects/UIAutomation/Screenshots/\\{TestContext.CurrentContext.Test.Name}.jpg";
            var result = TestContext.CurrentContext.Result.Outcome;
            if (result.Equals(ResultState.Failure) || result.Equals(ResultState.Error))
            {
                screenshot.SaveAsFile(filePath);
            }
        }
    }
}
