using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class DriverHelper
    {        
        private IWebDriver driver = new ChromeDriver("C:/Projects/UIAutomation/bin/Debug");
        public IWebDriver Driver
        {
            get => driver;
            set => driver = value;
        }
    }
}
