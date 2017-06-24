using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using BDD_SPECFLOW_DEMO.UIs;
using TechTalk.SpecFlow;

namespace BDD_SPECFLOW_DEMO.Steps
{
    [Binding]
    public class TC_01_Steps
    {

        private IWebDriver driver;

        [Given(@"I am on LiveGuru site")]
        public void GivenIAmOnLiveGuruSite()
        {
            driver = new ChromeDriver(@"G:\EXCERCISE\BDD_SPECFLOW_DEMO\BDD_SPECFLOW_DEMO\BDD_SPECFLOW_DEMO\Drivers");
            driver.Navigate().GoToUrl(MyAccountUI.MY_ACCOUNT_URL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }
        
        [Given(@"I input username (.*) and password (.*)")]
        public void GivenIInputUsernameAndPassword(String userName, String passWord)
        {
            driver.FindElement(By.XPath(MyAccountUI.USERNAME_TXT)).SendKeys(userName);
            driver.FindElement(By.XPath(MyAccountUI.PASSWORD_TXT)).SendKeys(passWord);
        }

        [Given(@"I input username and password")]
        public void GivenIInputUsernameAndPassword(Table table)
        {
            driver.FindElement(By.XPath(MyAccountUI.USERNAME_TXT)).SendKeys(table.Rows[0]["email"]);
            driver.FindElement(By.XPath(MyAccountUI.PASSWORD_TXT)).SendKeys(table.Rows[0]["pass"]);
        }


        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            driver.FindElement(By.XPath(MyAccountUI.LOGIN_BTN)).Click();
        }
        
        [Then(@"The error message should be displayed")]
        public Boolean ThenTheErrorMessageShouldBeDisplayed()
        {
            IWebElement errorMessage = driver.FindElement(By.XPath(MyAccountUI.INVALID_ERROR_MSG));
            return errorMessage.Displayed;

        }

        [Then(@"I verify the failure message")]
        public bool ThenIVerifyTheFailureMessage(Table table)
        {
            string control = string.Format(MyAccountUI.DYNAMIC_INVALID_ERROR_MSG, table.Rows[0]["error"]);
            IWebElement element = driver.FindElement(By.XPath(control));
            return element.Displayed;
        }
  


        [Then(@"The error message (.*) should be shown on form")]
        public bool ThenTheErrorMessageInvalidLoginOrPassword_ShouldBeShownOnForm(string errorMsg)
        {
            string control = string.Format(MyAccountUI.DYNAMIC_INVALID_ERROR_MSG, errorMsg);
            IWebElement element = driver.FindElement(By.XPath(control));
            return element.Displayed;
        }


        [Then(@"I quit browser")]
        public void ThenIQuitBrowser()
        {
            driver.Close();
        }

    }
}
