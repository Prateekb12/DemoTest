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
using System.Threading.Tasks;

namespace POC_Test.Pages
{
    class DashBoardPage : BasePage
    {
        // Object for DashBoard Page

        [FindsBy(How = How.ClassName, Using = "container")]
        IWebElement optionbar { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My Dashboard')]")]
        IWebElement My_Dashboard_button { get; set; }

        [FindsBy(How = How.ClassName, Using = "SkinnyTitleText")]
         IWebElement WelcomeBanner { get; set; }

   

        public void Optionsheader()

        {
           Thread.Sleep(10000);
            Actions actions = new Actions(DriverContext.Driver);
            Thread.Sleep(5000);
            actions.MoveToElement(optionbar);
            Assert.IsTrue(optionbar.Displayed);
            Console.WriteLine(optionbar.Displayed.ToString());
          

        }

        public NewsPage ClickMyDashboard()

        {
            Thread.Sleep(10000);
            Actions actions = new Actions(DriverContext.Driver);
            Console.WriteLine("Reached My dashboard");
            Thread.Sleep(5000);

            actions.MoveToElement(My_Dashboard_button);
            My_Dashboard_button.Click();
            Console.WriteLine("Clicked Dashboard");
            Thread.Sleep(5000);
            Assert.IsTrue(WelcomeBanner.Displayed);
            return GetInstance<NewsPage>();


        }


        

        





    }
}
