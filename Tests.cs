using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumTesting
{
    public class Tests : IDisposable
    {
        private IWebDriver driver;

        public Tests()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Fact]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var usernameField = driver.FindElement(By.Id("user-name"));
            usernameField.SendKeys("standard_user");

            var passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("secret_sauce");

            var loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();

            var productPageTitle = driver.FindElement(By.ClassName("title"));
            Xunit.Assert.True(productPageTitle.Text.Contains("Products"));
        }

        [Fact]
        public void SearchTest()
        {

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var usernameField = driver.FindElement(By.Id("user-name"));
            usernameField.SendKeys("standard_user");

            var passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("secret_sauce");

            var loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();

            var productPageTitle = driver.FindElement(By.ClassName("title"));
            Xunit.Assert.True(productPageTitle.Text.Contains("Products"));
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
