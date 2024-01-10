// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net;

static void TimeAndMaterial()
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
    Thread.Sleep(1000);

    //click login 
    IWebElement login1 = driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > input.btn.btn-default"));
    login1.Click();

    //Test Case to create new Time and Material

    IWebElement Admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
    Admin.Click();

    IWebElement tANDm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
    tANDm.Click();

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

    Console.WriteLine("Time and Materials created and submitted");
    Thread.Sleep(1000);


    // TEST CASE TO -- EDIT TIME AND MATERIAL

    //Navigate to Time & Material module (Click on Administration -> Time & Material link)
    // IWebElement admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
    //admin.Click();

    //IWebElement TimeandMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a" ));
    //TimeandMaterial.Click();
    //Thread.Sleep(1000);





    IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
    goToLastPage.Click();

    Thread.Sleep(1000);

    Thread.Sleep(3000);

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

    Thread.Sleep(3000);

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

    // IWebElement goToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
    // goToLastPage1.Click();

































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
      }*/

}


TimeAndMaterial();


