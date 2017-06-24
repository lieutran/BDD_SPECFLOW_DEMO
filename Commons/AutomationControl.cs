using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_SPECFLOW_DEMO.Commons
{
    public class AutomationControl
    {
        public IWebElement findElement(IWebDriver driver, string controlName)
        {
            IWebElement element = null;
            element = driver.FindElement(By.XPath(controlName));
            return element;
        }

        public IWebElement findElement(IWebDriver driver, string specialControl, string value)
        {
            IWebElement element = null;
            string control = string.Format(specialControl, value);
            element = driver.FindElement(By.XPath(control));
            return element;
        }

        public By getBy(IWebDriver driver, string controlName)
        {
            By by = null;
            by = By.XPath(controlName);
            return by;
        }

        public By getBy(IWebDriver driver, string specialControl, string value)
        {
            By by = null;
            string control = string.Format(specialControl, value);
            by = By.XPath(control);
            return by;
        }
    }
}
