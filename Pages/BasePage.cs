using OpenQA.Selenium;

namespace Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetCurrentUrl() => Driver.Url;
    }
}
