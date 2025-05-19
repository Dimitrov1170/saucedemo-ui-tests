using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class InventoryPage : BasePage
    {
        private readonly By addToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By removeBackpackButton = By.Id("remove-sauce-labs-backpack");
        private readonly By cartBadge = By.ClassName("shopping_cart_badge");
        private readonly By sortDropdown = By.ClassName("product_sort_container");
        private readonly By itemPrices = By.ClassName("inventory_item_price");
        private readonly By backpackName = By.CssSelector(".inventory_item_name");
        private readonly By backpackPrice = By.CssSelector(".inventory_item_price");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public void AddBackpackToCart() => Driver.FindElement(addToCartButton).Click();
        public void RemoveBackpackFromCart() => Driver.FindElement(removeBackpackButton).Click();
        public string GetFirstProductName() => Driver.FindElements(backpackName)[0].Text;
        public string GetFirstProductPrice() => Driver.FindElements(backpackPrice)[0].Text;

        public int GetCartItemCount()
        {
            string count = Driver.FindElement(cartBadge).Text;
            return int.Parse(count);
        }
        public bool IsCartEmpty()
        {
            var badges = Driver.FindElements(cartBadge);
            return badges.Count == 0;
        }
        public void SortByPriceLowToHigh()
        {
            var dropdown = new SelectElement(Driver.FindElement(sortDropdown));
            dropdown.SelectByValue("lohi");
        }

        public List<decimal> GetAllDisplayedPrices()
        {
            var priceElements = Driver.FindElements(itemPrices);
            return priceElements
                .Select(e => decimal.Parse(e.Text.Replace("$", "")))
                .ToList();
        }
    }
}
