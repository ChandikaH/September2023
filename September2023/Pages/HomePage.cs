using NUnit.Framework;
using OpenQA.Selenium;

namespace September2023.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try
            {
                // Navigate to Time & Material module
                IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationDropdown.Click();
            }
            catch(Exception exception)
            {
                Assert.Fail("Turnup portal Home page not displayed", exception.Message);
            }

            IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
            tmOption.Click();
        }
    }
}
