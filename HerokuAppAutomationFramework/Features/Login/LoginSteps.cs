using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HerokuAppAutomationFramework.Features.Login
{
    [Binding]
    [Scope(Tag = "login")]
    public class LoginSteps
    {
        IWebDriver driver;

        [BeforeScenario]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I am on Login page")]
        public void GivenIAmOnLoginPage()
        {
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
        }
        
        [When(@"I enter '(.*)' for Username and '(.*)' for Password")]
        public void WhenIEnterForUsernameAndForPassword(string username, string password)
        {
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
        }
        
        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            driver.FindElement(By.CssSelector("#login > button")).Click();
        }
        
        [Then(@"I should see successful login message")]
        public void ThenIShouldSeeSuccessfulLoginMessage()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector(".flash.success")).Displayed);
        }
        
        [Then(@"I should see Logout button")]
        public void ThenIShouldSeeLogoutButton()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("#content > div > a > i")).Displayed);
        }
        
        [Then(@"I should see invalid password message")]
        public void ThenIShouldSeeInvalidPasswordMessage()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector(".flash.error")).Displayed);
        }
        
        [Then(@"I should see Login button")]
        public void ThenIShouldSeeLoginButton()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("#login > button")).Displayed);
        }
        
        [Then(@"I should see invalid username message")]
        public void ThenIShouldSeeInvalidUsernameMessage()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector(".flash.error")).Displayed);
        }

        [AfterScenario]
        public void TestCleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
