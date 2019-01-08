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
    class NewsPage : BasePage

    {
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'News')]")]
        public IWebElement News_button { get; set; }

        [FindsBy(How = How.Id, Using = "WelcomeMessage")]
        public IWebElement Message_board { get; set; }

        public MyRecentActivity ClickNews()

        {
            Thread.Sleep(10000);
            News_button.Click();
            Thread.Sleep(5000);
            Console.WriteLine("Clicked News");
            Thread.Sleep(5000);
            Assert.IsTrue(Message_board.Displayed);
            return GetInstance<MyRecentActivity>();
        }
    }
}
