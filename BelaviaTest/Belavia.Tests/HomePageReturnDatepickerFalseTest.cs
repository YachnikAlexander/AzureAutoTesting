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
    public class HomePageReturnDatepickerFalseTest : BaseTest
    {
        private HomePage homePage;
        private SelectElement arrivalAirports;
        private IWebElement departureAirport;

        //[TestMethod]
        //public void NullTicketReturnDateField()
        //{
        //    homePage = new HomePage();
        //    homePage.OpenHomePage();
        //    homePage.ClickField();
        //    homePage.ClickSecondField();
        //    Thread.Sleep(2000);
        //    homePage.SelectOneWayTicket();
        //    var ticketDate = homePage.GetReturnTicketDate();
        //    CleanupTest();
        //    Thread.Sleep(2000);
        //    Assert.AreEqual(false, ticketDate.Displayed);
            
        //}

    }
}
