using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage : BasePage
    {
        private readonly By usernameField = By.Id("user-name");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void EnterUsername(string username) => Driver.FindElement(usernameField).SendKeys(username);
        public void EnterPassword(string password) => Driver.FindElement(passwordField).SendKeys(password);
        public void ClickLogin() => Driver.FindElement(loginButton).Click();

        public void LoginAs(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }
}
