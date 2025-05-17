using Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using Pages;
using Utilities;

namespace Tests
{
    public class LoginTests
    {
        private IWebDriver driver;
        private const string url = "https://www.saucedemo.com/";

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Login_WithValidCredentials_ShouldSucceed()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("standard_user", "secret_sauce");

            Assert.That(driver.Url, Does.Contain("inventory.html"));
        }
        [Test]
        public void Login_WithInvalidUsername_ShouldStayOnLoginPage()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("wrong_user", "secret_sauce");

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
        }
        [Test]
        public void Login_WithEmptyFields_ShouldShowError()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("", "");

            var error = WaitHelper.WaitForElementVisible(driver, By.CssSelector("[data-test='error']")).Text;

            Assert.That(error, Does.Contain("Username is required"));
        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
