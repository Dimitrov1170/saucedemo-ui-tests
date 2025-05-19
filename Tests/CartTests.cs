using NUnit.Framework;
using OpenQA.Selenium;
using Drivers;
using Pages;

namespace Tests
{
    public class CartTests : BaseTest
    {

        [Test]
        public void AddItemToCart_ShouldIncreaseCartBadge()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddBackpackToCart();

            int cartCount = inventoryPage.GetCartItemCount();
            Assert.That(cartCount, Is.EqualTo(1));
        }

        [Test]
        public void RemoveItemFromCart_ShouldClearCartBadge()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddBackpackToCart();
            inventoryPage.RemoveBackpackFromCart();

            Assert.That(inventoryPage.IsCartEmpty(), Is.True);
        }
        
        [Test]
        public void SortByPriceLowToHigh_ShouldDisplayPricesInAscendingOrder()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginAs("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.SortByPriceLowToHigh();

            var prices = inventoryPage.GetAllDisplayedPrices();
            var sorted = prices.OrderBy(p => p).ToList();

            CollectionAssert.AreEqual(sorted, prices);
        }
    }
}
