using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceturnup.Pages
{
    public class Homepage
    {
        public void GotoTMPage(IWebDriver driver)
        {
            IWebElement Admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Admin.Click();

            IWebElement tANDm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tANDm.Click();
        }
    }
}