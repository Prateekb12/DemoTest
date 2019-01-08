using DemoTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace POC_Test.Pages 
{
    class MyRecentActivity : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My Recent Activity')]")]
        public IWebElement My_recent_activity_btn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MainContentControl_RecentItems_UpdatePanelRecentVacancies']")]
        public IWebElement My_recent_Vacancies { get; set; }

        public void ClickRecentActivities()

        {
            Thread.Sleep(10000);
            My_recent_activity_btn.Click();
            Thread.Sleep(5000);
            Actions actions = new Actions(DriverContext.Driver);
            Thread.Sleep(5000);
            actions.MoveToElement(My_recent_Vacancies);
            actions.Perform();
            Assert.IsTrue(My_recent_Vacancies.Displayed);
            Console.WriteLine("Clicked recent Activities");

        }
    }
}
