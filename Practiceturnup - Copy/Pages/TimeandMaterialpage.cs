using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceturnup.Pages
{
    public class TimeandMaterialpage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Test Case to create new Time and Material

            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();

            Thread.Sleep(1000);

            //Select Time from dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeMainDropdown.Click();


            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typeCodeDropdown.Click();

            //Enter Code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("VandanaKodiganti");

            // Enter Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Create new T & M");

            //Enter price
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("100.00");

            //Click Save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);

            Console.WriteLine("Time and Materials created and submitted");
            Thread.Sleep(1000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(1000);
        }
        public void EditTimeRecord(IWebDriver driver)
        {

            Thread.Sleep(1000);

            IWebElement table1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table"));

            // Get all rows from the table
            IList<IWebElement> rows1 = table1.FindElements(By.TagName("tr"));

            var EditXpathString1 = "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[";
            int tableRowNumber1 = rows1.Count;
            var EditXpathString2 = "]/td[5]/a[1]";
            var EditFieldXpathValue = EditXpathString1 + tableRowNumber1.ToString() + EditXpathString2;

            IWebElement EditButton = driver.FindElement(By.XPath(EditFieldXpathValue));
                  EditButton.Click();
            Thread.Sleep(1000);

            //Edit  Code Item Task7

            IWebElement code1 = driver.FindElement(By.Id("Code"));
            code1.Click();
            code1.SendKeys(Keys.Control + "a");
            code1.SendKeys(Keys.Delete);
            code1.SendKeys("Vandana Name Updated");

            //Edit  description

            Thread.Sleep(1000);

            IWebElement descriptionTextbox1 = driver.FindElement(By.Id("Description"));
            descriptionTextbox1.Click();
            descriptionTextbox1.SendKeys(Keys.Control + "a");
            descriptionTextbox1.SendKeys(Keys.Delete);
            descriptionTextbox1.SendKeys(" test selenium123");

            //Save button

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();

            Thread.Sleep(3000);
            IWebElement gotoLast = driver.FindElement(By.CssSelector("#tmsGrid > div.k-pager-wrap.k-grid-pager.k-widget > a.k-link.k-pager-nav.k-pager-last > span"));
            gotoLast.Click();
        }
        public void DeleteTimeRecord(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement table = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table"));

            // Get all rows from the table
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));

            var xpathString1 = "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[";
            int tableRowNumber = rows.Count;
            var xpathString2 = "]/td[5]/a[2]";
            var DeleteFieldXpathValue = xpathString1 + tableRowNumber.ToString() + xpathString2;

            IWebElement deleteButton = driver.FindElement(By.XPath(DeleteFieldXpathValue));
            deleteButton.Click();

            //Click OK on Delete Confirmation pop-up
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
