using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace September2023.Pages
{
    public class TMPage
    {
        // Test Case - Create a new Time record
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Click on the Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // Select Time from dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeMainDropdown.Click();
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typeCodeDropdown.Click();

            // Enter Code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("September2023");

            // Enter Description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Desc September 2023");

            // Enter the Price
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("150.50");

            // Click on the Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(5000);

            // Check if a new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "September2023")
            {
                Console.WriteLine("New time record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Time Record has not been created");
            }
        }

        public void EditTimeRecord(IWebDriver driver) 
        { 
            //Code for Edit Time Record
        }

        public void DeleteTimeRecord(IWebDriver driver) 
        {
            //Code for Delete Time Record
        }
    }
}
