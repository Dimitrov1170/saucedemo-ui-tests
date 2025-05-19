using NUnit.Framework;
using OpenQA.Selenium;
using Drivers;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected const string BaseUrl = "https://www.saucedemo.com/";

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
            driver.Navigate().GoToUrl(BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
