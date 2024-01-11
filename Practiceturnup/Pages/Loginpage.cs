using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceturnup.Pages
{
    public class Loginpage
    {
        public void LoginAction(IWebDriver driver)
        {
            //Launch the website
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Identify username and enter text 
            IWebElement username1 = driver.FindElement(By.Id("UserName"));
            username1.SendKeys("hari");

            //Identify password and enter text
            IWebElement password1 = driver.FindElement(By.Id("Password"));
            password1.SendKeys("123123");
            Thread.Sleep(1000);

            //click login 
            IWebElement login1 = driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > input.btn.btn-default"));
            login1.Click();
        }
    }
}
