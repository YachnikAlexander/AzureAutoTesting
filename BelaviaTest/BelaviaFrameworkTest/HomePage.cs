using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BelaviaFrameworkTest
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string Url = "https://belavia.by";
        By cookiesSet = By.Id("set_cookies");
        By oneWayTicketCheckbox = By.Id("JourneySpan_Ow");
        By leavingTicketDate = By.Id("DepartureDate_Datepicker");
        By returnTicketDate = By.Id("ReturnDate_Datepicker");
        By departure = By.XPath("//*[@id='ibe']/form/div[1]/div[1]/div/a");
        By departureList = By.XPath("//*[@id='ui-id-2']/li");
        By arrival = By.XPath("//*[@id='ibe']/form/div[1]/div[2]/div/a");
        By arrivalList = By.XPath("//*[@id='ui-id-3']/li");
        By bookingFormSubmitButton = By.XPath("//*[@id='step - 2']/div[4]/div/button");
        By errorsMessages = By.ClassName("messages");

        private void SelectDeparture()
        {
            var placeToLeave = new SelectElement(driver.FindElement(departure));
            placeToLeave.SelectByIndex(1);//Because "zero" value is default
        }

        private void ChooseValueOfSelectTag(By selector, int index)
        {
            var selectElement = new SelectElement(driver.FindElement(selector));
            selectElement.SelectByIndex(index);//Because "zero" value is default
        }

        public HomePage()
        {
            this.driver = Driver.GetDriverInstance();
        }

        public void OpenHomePage()
        {
            GoToUrl(Url);
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CloseAds()
        {
            driver.FindElement(cookiesSet).Click();
            Thread.Sleep(1000);
        }

        public void SelectOneWayTicket()
        {
            driver.FindElement(oneWayTicketCheckbox).Click();
        }

        public IWebElement GetReturnTicketDate()
        {
            return driver.FindElement(returnTicketDate);
        }

        public IWebElement GetLeavingTicketDate()
        {
            return driver.FindElement(leavingTicketDate);
        }


        public void FillInBookingForm()
        {
            ChooseValueOfSelectTag(departure, 1);
            ChooseValueOfSelectTag(arrival, 12);

            SetDateTime(driver.FindElement(leavingTicketDate), DateTime.Now.ToString("dd'/'MM'/'yyyy"));
            SetDateTime(GetReturnTicketDate(), DateTime.Now.ToString("dd'/'MM'/'yyyy"));
        }

        public IEnumerable<IWebElement> GetDepartureList()
        {
            var dep = driver.FindElement(departure);
            dep.Click();
            var childrens = driver.FindElements(departureList);
            return childrens;
        }

        public IEnumerable<IWebElement> GetArrivalList()
        {
            var dep = driver.FindElement(arrival);
            dep.Click();
            var childrens = driver.FindElements(arrivalList);
            return childrens;
        }

        public SelectElement GetArrivalAirportOptions()
        {
            return new SelectElement(driver.FindElement(arrival));
        }

        public void SetDateTime(IWebElement el, string value)
        {
            el.SendKeys(value);
        }

        public IWebElement GetElement(By selector)
        {
            return driver.FindElement(selector);
        }

        public void SubmitBookingForm()
        {
            driver.FindElement(bookingFormSubmitButton).Click();
        }

        public IWebElement GetErrorMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}
