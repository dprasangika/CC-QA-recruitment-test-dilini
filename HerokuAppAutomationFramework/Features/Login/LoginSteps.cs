using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HerokuAppAutomationFramework.Features.Login
{
    [Binding]
    [Scope(Tag = "login")]
    public class LoginSteps : TestBase
    {
        

        [BeforeScenario]
        public void TestInitialize()
        {
            Initialize();
        }

        [Given(@"I am on Login page")]
        public void GivenIAmOnLoginPage()
        {
            Navigate();
        }

        [When(@"I enter '(.*)' for Username and '(.*)' for Password")]
        public void WhenIEnterForUsernameAndForPassword(string username, string password)
        {
            Login(username, password);
        }
        
        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            driver.FindElement(By.CssSelector("#login > button")).Click();
        }
        
        [Then(@"I should see successful login message")]
        public void ThenIShouldSeeSuccessfulLoginMessage()
        {
            var successMessage = driver.FindElement(By.CssSelector(".flash.success"));
            Assert.IsTrue(successMessage.Displayed);
        }
        
        [Then(@"I should see Logout button")]
        public void ThenIShouldSeeLogoutButton()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("#content > div > a > i")).Displayed);
        }
        
        [Then(@"I should see invalid password message")]
        public void ThenIShouldSeeInvalidPasswordMessage()
        {
            var passwordErrorMessage = driver.FindElement(By.CssSelector(".flash.error"));
            Assert.IsTrue(passwordErrorMessage.Displayed);
        }
        
        [Then(@"I should see Login button")]
        public void ThenIShouldSeeLoginButton()
        {
            Assert.IsTrue(driver.FindElement(By.CssSelector("#login > button")).Displayed);
        }
        
        [Then(@"I should see invalid username message")]
        public void ThenIShouldSeeInvalidUsernameMessage()
        {
            var usernameErrorMessage = driver.FindElement(By.CssSelector(".flash.error"));
            Assert.IsTrue(usernameErrorMessage.Displayed);
        }

        [AfterScenario]
        public void TestCleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
