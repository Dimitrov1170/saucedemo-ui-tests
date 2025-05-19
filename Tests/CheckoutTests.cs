using Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using Pages;
using Utilities;

namespace Tests
{
    public class CheckoutTests : BaseTest
    {

        [Test]
        public void Checkout_WithValidData_ShouldProceedToOverviewPage()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddBackpackToCart();
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();

            var cartPage = new CartPage(driver);
            cartPage.ClickCheckout();

            var checkoutPage = new CheckoutPage(driver);
            checkoutPage.FillInCheckoutInfo("Georgi", "Dimitrov", "1000");

            Assert.That(driver.Url, Does.Contain("checkout-step-two"), "Did not navigate to Checkout Overview page.");

        }


        [Test]
        public void Checkout_WithMissingPostalCode_ShouldShowError()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddBackpackToCart();
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();

            var cartPage = new CartPage(driver);
            cartPage.ClickCheckout();

            var checkoutPage = new CheckoutPage(driver);
            checkoutPage.FillInCheckoutInfo("Georgi", "Dimitrov", ""); // No ZIP

            var errorElement = WaitHelper.WaitForElementVisible(driver, By.CssSelector("[data-test='error']"));
            string error = errorElement.Text;

            Assert.That(error, Does.Contain("Postal Code is required"));
        }
    }
}
