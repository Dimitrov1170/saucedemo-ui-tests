using OpenQA.Selenium;

namespace Pages
{
    public class CheckoutPage : BasePage
    {
        private readonly By firstName = By.Id("first-name");
        private readonly By lastName = By.Id("last-name");
        private readonly By postalCode = By.Id("postal-code");
        private readonly By continueButton = By.Id("continue");
        private readonly By finishButton = By.Id("finish");
        private readonly By completeHeader = By.ClassName("complete-header");

        public CheckoutPage(IWebDriver driver) : base(driver) { }

        public void FillInCheckoutInfo(string fName, string lName, string zip)
        {
            Driver.FindElement(firstName).Clear();
            Driver.FindElement(firstName).SendKeys(fName);

            Driver.FindElement(lastName).Clear();
            Driver.FindElement(lastName).SendKeys(lName);

            Driver.FindElement(postalCode).Clear();
            Driver.FindElement(postalCode).SendKeys(zip);

            Driver.FindElement(continueButton).Click();
        }

        public void ClickFinish() => Driver.FindElement(finishButton).Click();


        public string GetSuccessMessage()
        {
            return Driver.FindElement(completeHeader).Text;
        }

    }
}
