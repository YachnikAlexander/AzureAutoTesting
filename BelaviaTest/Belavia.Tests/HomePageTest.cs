using System;
using System.Linq;
using BelaviaFrameworkTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Belavia.Tests
{
    [TestClass]
    public class HomePageTest : BaseTest
    {
        private HomePage homePage;
        private SelectElement arrivalAirports;
        private IWebElement departureAirport;

        [TestInitialize]
        public void HomePageInitialization()
        {
            homePage = new HomePage();
            homePage.OpenHomePage();
        }

        [TestMethod]
        public void AssertNoSourceAirportInDestinationDropdown()
        {
            var departureList = homePage.GetDepartureList();
            var arrivalList = homePage.GetArrivalList();
            var exist = departureList.Any(i => i.Text.Equals(arrivalAirports));
            Assert.AreEqual(false, exist);
        }

    }
}
