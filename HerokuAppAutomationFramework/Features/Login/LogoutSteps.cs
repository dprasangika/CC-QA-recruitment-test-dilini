using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HerokuAppAutomationFramework.Features.Login
{
    [Binding]
    [Scope(Tag = "logout")]
    public class LogoutSteps
    {
        IWebDriver driver;

        [BeforeScenario]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I am logged in with '(.*)' Username and '(.*)' Password")]
        public void GivenIAmLoggedInWithUsernameAndPassword(string username, string password)
        {
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.CssSelector("#login > button")).Click();
        }
        
        [When(@"I click Logout button")]
        public void WhenIClickLogoutButton()
        {
            driver.FindElement(By.CssSelector("#content > div > a")).Click();
        }

        [Then(@"I should see successful logout message")]
        public void ThenIShouldSeeSuccessfulLogoutMessage()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector(".flash.success")).Displayed);
        }

        [Then(@"I should see Login button")]
        public void ThenIShouldSeeLoginButton()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("#login > button")).Displayed);
        }


        [AfterScenario]
        public void TestCleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
