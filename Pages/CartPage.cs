using OpenQA.Selenium;

namespace Pages
{
    public class CartPage : BasePage
    {
        private readonly By checkoutButton = By.Id("checkout");

        public CartPage(IWebDriver driver) : base(driver) { }

        public void ClickCheckout() => Driver.FindElement(checkoutButton).Click();
    }
}
