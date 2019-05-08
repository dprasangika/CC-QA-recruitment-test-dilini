using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppAutomationFramework
{
    public class TestBase
    {

        public IWebDriver driver;
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
        }

        public void Login(string username, string password)
        {
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
        }
    }
}
