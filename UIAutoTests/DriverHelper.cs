using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutoTests
{
    public class DriverHelper
    {
        private static  IWebDriver driver = new ChromeDriver("C:/Projects/UIAutomation/bin/Debug");
        public static IWebDriver Driver
        {
            get => driver;
            set => driver = value;
        }
    }
}
