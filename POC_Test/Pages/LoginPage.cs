using DemoTest.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using DemoTest.Extensions;

namespace POC_Test.Pages
{
    [Binding]
    class LoginPage : BasePage
    {
      

     // Object for login page
    [FindsBy(How = How.Id, Using = "UserID")]
    IWebElement userIDBox { get; set; }

    [FindsBy(How = How.Id, Using = "Password")]

    IWebElement passwordBox { get; set; }


    [FindsBy(How = How.Id, Using = "Login")]
    IWebElement LoginButton { get; set; }
      
    public void Login(string username, string password)
        {
            Console.WriteLine("Entered login");
            Console.WriteLine(userIDBox);
            userIDBox.SendKeys(username);         
            passwordBox.SendKeys(password);

        }

    public DashBoardPage ClickLogin()
        {
            LoginButton.Click();
            return GetInstance<DashBoardPage>();
            
        }

}



    }

