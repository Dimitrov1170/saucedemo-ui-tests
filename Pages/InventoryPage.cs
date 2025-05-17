using OpenQA.Selenium;

namespace Pages
{
    public class InventoryPage : BasePage
    {
        private readonly By addToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By cartBadge = By.ClassName("shopping_cart_badge");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public void AddBackpackToCart() => Driver.FindElement(addToCartButton).Click();
        public int GetCartItemCount()
        {
            string count = Driver.FindElement(cartBadge).Text;
            return int.Parse(count);
        }
    }
}
