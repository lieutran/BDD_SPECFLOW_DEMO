using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_SPECFLOW_DEMO.Commons
{
    public class AbstractPage
    {
        public int timeWait = 30;
        public int timeSleep = 2;
        public IWebElement element;
        public AutomationControl control = new AutomationControl();

        public void waitForControl(IWebDriver driver, string controlName)
        {
            try
            {
                By by = control.getBy(driver, controlName);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void waitForControl(IWebDriver driver, string controlName, string value)
        {
            try
            {
                By by = control.getBy(driver, controlName, value);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool isControlDisplayed(IWebDriver driver, string controlName)
        {
            try
            {
                element = control.findElement(driver, controlName);
                return element.Displayed;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool isControlDisplayed(IWebDriver driver, string controlName, string value)
        {
            try
            {
                element = control.findElement(driver, controlName, value);
                return element.Displayed;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void click(IWebDriver driver, string controlName)
        {
            waitForControl(driver, controlName);
            element = control.findElement(driver, controlName);
            element.Click();
        }

        public void type(IWebDriver driver, string controlName, string value)
        {
            waitForControl(driver, controlName);
            element = control.findElement(driver, controlName);
            element.Clear();
            element.SendKeys("\u0008" + value);
        }

        public void selectItemCombobox(IWebDriver driver, string controlName, string item)
        {
            element = control.findElement(driver, controlName);
            SelectElement select = new SelectElement(element);
            select.SelectByText(item);
        }

        public String getText(IWebDriver driver, string controlName)
        {
            try
            {
                waitForControl(driver, controlName);
                IWebElement element = control.findElement(driver, controlName);
                return element.Text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
