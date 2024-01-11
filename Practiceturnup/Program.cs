using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Practiceturnup.Pages;
using System.Net;

public class Program
{
    private static void Main(string[] args)
    {
        static void login()
        {
            //open chrome driver
            IWebDriver driver = new ChromeDriver();

            //Login Page Object initilization

            Loginpage LoginPageObj = new Loginpage();
            LoginPageObj.LoginAction(driver);

            //Home Page Object  initilization

            Homepage HomepageObj = new Homepage();
            HomepageObj.GotoTMPage(driver);

            //Time and Material Object initilization

            TimeandMaterialpage tmpageObj = new TimeandMaterialpage();

                         tmpageObj.CreateTimeRecord(driver);
                         tmpageObj.EditTimeRecord(driver);
                         tmpageObj.DeleteTimeRecord(driver);

        }


        login();
    }
}



















































/*
/* TEST CASE TO ADD NEW CUSTOMER DETAILS

//enter customer details

IWebElement Admin = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown > a"));
Admin.Click();

IWebElement Cust = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown.open > ul > li:nth-child(1) > a"));
Cust.Click();

Thread.Sleep(500);
//IWebElement TotalCount = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[3]/div/table/tbody/tr/td[2]"));

//var BeforeNewCustTotalCount = TotalCount.GetAttribute("innerHMTL");

IWebElement CustDet = driver.FindElement(By.CssSelector("#container > p > a"));
CustDet.Click();

IWebElement NewCust = driver.FindElement(By.Id("Name"));
NewCust.SendKeys("Vandana");

IWebElement EditCon = driver.FindElement(By.Id("EditContactButton"));
EditCon.Click();

//string newWindowHandle = driver.CurrentWindowHandle.Last();
//driver.CurrentWindowHandle.Last();

Thread.Sleep(500);

driver.SwitchTo().Window(driver.WindowHandles.Last());

driver.SwitchTo().Frame(0);

IWebElement fname1 = driver.FindElement(By.CssSelector("#FirstName"));
fname1.SendKeys("Vandu");

IWebElement lname1 = driver.FindElement(By.CssSelector("#LastName"));
lname1.SendKeys("Kodiganti");

IWebElement Pname = driver.FindElement(By.Id("PreferedName"));
 Pname.SendKeys("Ravi");

IWebElement Phone = driver.FindElement(By.Id("Phone"));
  Phone.SendKeys("123456789");

    IWebElement Mobile1 = driver.FindElement(By.Id("Mobile"));
Mobile1.SendKeys("123456789");

        IWebElement Email = driver.FindElement(By.Id("email"));
Email.SendKeys("Vandu@yahoo.com");

IWebElement Fax1 = driver.FindElement(By.Id("Fax"));
Fax1.SendKeys("123456789");

IWebElement Address = driver.FindElement(By.Id("autocomplete"));
Address.SendKeys("Spring Avenuue");

IWebElement Street = driver.FindElement(By.Id("Street"));
Street.SendKeys("Spring Avenuue");

IWebElement City = driver.FindElement(By.Id("City"));
City.SendKeys("Brisbane");

IWebElement Postcode = driver.FindElement(By.Id("Postcode"));
Postcode.SendKeys("4311");

IWebElement Country = driver.FindElement(By.Id("Country"));
Country.SendKeys("Australia");

IWebElement  Savebutton = driver.FindElement(By.Id("submitButton"));
Savebutton.SendKeys("Spring Avenuue");

Thread.Sleep(1000);

driver.SwitchTo().Window(driver.WindowHandles.Last());


IWebElement SameContactbutton = driver.FindElement(By.XPath("//*[@id=\"IsSameContact\"]"));
//IWebElement SameContactbutton = driver.FindElement(By.CssSelector("#IsSameContact"));
//#IsSameContact
SameContactbutton.Click();

//GST
IWebElement GST = driver.FindElement(By.Id("GST"));
GST.SendKeys("20");

//submitButton

IWebElement Savebutton1 = driver.FindElement(By.Id("submitButton"));
Savebutton1.Click();

// Verify Customer is saved successfully
//#clientsGrid > div.k-grid-footer > div > table > tbody > tr > td:nth-child(2)

IWebElement Admin1 = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown > a"));
Admin1.Click();

IWebElement Cust1 = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown.open > ul > li:nth-child(1) > a"));
Cust1.Click();

Thread.Sleep(1000);
IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span"));
goToLastPage.Click();*/


// IWebElement TotalCountNew = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[3]/div/table/tbody/tr/td[2]"));
// var AfterNewCustTotalCount = TotalCountNew.GetAttribute("innerHTML");


/*  if (BeforeNewCustTotalCount+1 == AfterNewCustTotalCount)
  {
      Console.WriteLine("New Customer Creation Passed");
      Console.WriteLine("PASSED " + BeforeNewCustTotalCount + "--" + AfterNewCustTotalCount);
  }
  else
  {
      Console.WriteLine("New Customer Creation Failed");
      Console.WriteLine("FAILED " + BeforeNewCustTotalCount + "--" + AfterNewCustTotalCount);
  }  */


