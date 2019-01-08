using System;
using System.Threading;
using DemoTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using POC_Test.Pages;

namespace POC_Test
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "https://www.applitrack.com/dex/";


        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
            LoginPage loginPage = new LoginPage();
            loginPage.Login("tryout", "tryout");
          

            DashBoardPage dashBoardPage = loginPage.ClickLogin();
            dashBoardPage.Optionsheader();


            NewsPage newsPage = dashBoardPage.ClickMyDashboard();
           

            MyRecentActivity myRecentActivity = newsPage.ClickNews();
            myRecentActivity.ClickRecentActivities();
        }
    }
}