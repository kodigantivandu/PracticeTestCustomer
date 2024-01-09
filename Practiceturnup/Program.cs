// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

static void login()
{
    //open chrome driver
    IWebDriver driver = new ChromeDriver();

    //Launch the website
    driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

    //Identify username and enter text 
    IWebElement username1 = driver.FindElement(By.Id("UserName"));
    username1.SendKeys("hari");

    //Identify password and enter text
    IWebElement password1 = driver.FindElement(By.Id("Password"));
    password1.SendKeys("123123");

    //click login 
    IWebElement login1 = driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > input.btn.btn-default"));
    login1.Click();

    //enter customer details

    IWebElement Admin = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown > a"));
    Admin.Click();

    IWebElement Cust = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown.open > ul > li:nth-child(1) > a"));
    Cust.Click();


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


    IWebElement fname1 = driver.FindElement(By.CssSelector("#FirstName"));
    fname1.SendKeys("van");



    // IWebElement Fname1 = driver.FindElement(By.Name("FirstName"));
    // Fname1.SendKeys("Vandu");

   // IWebElement fname1 = driver.FindElement(by.c)
  //  fname1.SendKeys("VANDU");

   // driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
   // driver.SwitchTo().ActiveElement().Click();
  //  driver.SwitchTo().ActiveElement().SendKeys("Vandana");

  //  driver.SwitchTo().ActiveElement().SendKeys(Keys.Tab);
  //  driver.SwitchTo().ActiveElement().SendKeys("Kodiganti");

    //# contactDetailWindow_wnd_title
  //  Thread.Sleep(500);



   // var windowdetails = driver.FindElement(By.CssSelector("#FirstName"));

   // windowdetails.Click();
   // windowdetails.SendKeys("Vandana");

   // IWebElement Fname = driver.FindElement(By.Id("FirstName"));
   // Fname.SendKeys("vandu");


    //string newWindowHandle = _driver.WindowHandles.Last();
    //var newWindow = _driver.SwitchTo().Window(newWindowHandle);

    //object value = driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));


    //driver.SwitchTo().Window(driver.WindowHandles.Last());

    // driver.FindElement(By.CssSelector("#submitButton")).Click();


    // IWebElement Fname = driver.FindElement(By.CssSelector("#FirstName"));
    // Fname.SendKeys("Van1");

    //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    // IWebElement Fname1 = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("FirstName")));

    // Now you can interact with the element
    //  Fname.SendKeys("Van1");

    // IWebElement Lname = driver.FindElement(By.Id("LastName"));
    // Lname.SendKeys("Kod");




}



login();


