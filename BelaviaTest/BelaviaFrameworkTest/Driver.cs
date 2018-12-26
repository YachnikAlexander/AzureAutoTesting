using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BelaviaFrameworkTest
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriverInstance()
        {
            if (driver == null)
            {
                SetupChromeDriver();
            }
            return driver;
        }

        public static void SetupChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
