using System;
using System.Linq;
using System.Threading;
using BelaviaFrameworkTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Belavia.Tests
{
    [TestClass]
    public class HomePageAssertNoSourceTest : BaseTest
    {
        private HomePage homePage;
        private SelectElement arrivalAirports;
        private IWebElement departureAirport;

        [TestMethod]
        public void AssertNoSourceAirportInDestinationDropdown()
        {
            homePage = new HomePage();
            homePage.OpenHomePage();
            Thread.Sleep(1000);
            homePage.ClickField();
            var departureList = homePage.GetDepartureList();
            var arrivalList = homePage.GetArrivalList();
            var exist = departureList.Any(i => i.Text.Equals(arrivalAirports));
            CleanupTest();
            Thread.Sleep(2000);
            Assert.AreEqual(false, exist);
            
        }
    }
}
