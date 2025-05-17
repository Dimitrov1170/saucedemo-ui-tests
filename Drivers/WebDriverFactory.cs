using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drivers
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            return new ChromeDriver(options);
        }

    }
}
