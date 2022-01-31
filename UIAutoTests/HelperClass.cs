using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UIAutoTests
{
    public class HelperClass : PageObjects
    {
        public string url = "https://parabank.parasoft.com/";
        public string chromeDriverLocation = "C:/Projects/UIAutomation/bin/Debug";
        
        public void Setup()
        {
            Driver = new ChromeDriver(chromeDriverLocation);
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");
            Driver.Manage().Window.Maximize();
        }
        public void LoginTo()
        {
            var user = new PageObjects();
            Driver.Navigate().GoToUrl(url);
            WaitUntilelementIsPresent(user.loginNameBy);
            loginName.SendKeys("JoeBlack");
            WaitUntilelementIsPresent(user.loginPasswordBy);
            loginPassword.SendKeys("qwerasdf");
            WaitUntilelementIsPresent(user.loginButtonBy);
            loginButton.Click();                    
        }
        public void CloseBrowser()
        {
            Driver.Close();
        }

        public void WaitUntilelementIsPresent(By el)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            WebElement element = (WebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(el));            
        }

    }
}
