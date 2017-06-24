using BDD_SPECFLOW_DEMO.Commons;
using BDD_SPECFLOW_DEMO.UIs;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDD_SPECFLOW_DEMO.Steps
{
    [Binding]
    public class TC04_Steps:AbstractPage
    {
        IWebDriver driver;


        [Given(@"I am on ZingPoll website")]
        public void GivenIAmOnZingPollWebsite()
        {
            driver = new ChromeDriver(@"G:\EXCERCISE\BDD_SPECFLOW_DEMO\BDD_SPECFLOW_DEMO\BDD_SPECFLOW_DEMO\Drivers");
            driver.Navigate().GoToUrl(ZingPollUI.HOMEPAGE_URL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));

        }
        
        [Given(@"I click the SignIn button")]
        public void GivenIClickTheSignInButton()
        {
            waitForControl(driver, ZingPollUI.SIGN_IN_TITLE);
            click(driver, ZingPollUI.SIGN_IN_TITLE);
        }
        

        [When(@"I enter email (.*) and password (.*)")]
        public void WhenIEnterEmailAndPassword(string email, string password)
        {
            waitForControl(driver, ZingPollUI.EMAIL_TEXTBOX);
            type(driver, ZingPollUI.EMAIL_TEXTBOX, email);
            type(driver, ZingPollUI.PASSWORD_TEXTBOX, password);
        }
        
        [When(@"I click Submit button")]
        public void WhenIClickSubmitButton()
        {
            click(driver, ZingPollUI.LOGIN_BUTTON);
        }
        
        [Then(@"The SignIn form should be shown")]
        public void ThenTheSignInFormShouldBeShown()
        {
            waitForControl(driver, ZingPollUI.SIGN_IN_POPUP);
            isControlDisplayed(driver, ZingPollUI.SIGN_IN_POPUP);
        }
        
        [Then(@"I verify the error failure message (.*)")]
        public void ThenIVerifyTheErrorFailureMessage(String error)
        {
            waitForControl(driver, ZingPollUI.ERROR_NOT_REGISTERED_MESSAGE, error);
            isControlDisplayed(driver, ZingPollUI.ERROR_NOT_REGISTERED_MESSAGE, error);
        }
        
        [Then(@"I quit the browser")]
        public void ThenIQuitTheBrowser()
        {
            driver.Close();
        }
    }
}
