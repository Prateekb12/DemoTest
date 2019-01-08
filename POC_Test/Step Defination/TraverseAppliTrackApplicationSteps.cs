using DemoTest.Base;
using OpenQA.Selenium.Firefox;
using POC_Test.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace POC_Test.Step_Defination
{
    [Binding]
    class TraverseAppliTrackApplicationSteps : BaseStep
    {
        
        [Given(@"User has entered the correct application url on browser")]
        public void GivenUserHasEnteredTheCorrectApplicationUrlOnBrowser(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(data.Url);
            LoginPage loginPage = new LoginPage();

        }

        [Given(@"the application is loaded correctly")]
        public void GivenTheApplicationIsLoadedCorrectly()
        {
            DriverContext.Driver.Manage().Window.Maximize();
            Console.WriteLine("Window Maximized");
        }

        [When(@"User entered correct Username and Password")]
        public void WhenUserEnteredCorrectUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            LoginPage loginpage = new LoginPage();
            loginpage.Login(data.Username.ToString(), data.Password.ToString());
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLogin();
            Console.WriteLine("Login Clicked");


        }

        [When(@"User clicks on MyDashbard icon to visit News and Activitis section")]
        public void WhenUserClicksOnMyDashbardIconToVisitNewsAndActivitisSection()
        {
            CurrentPage = GetInstance<DashBoardPage>();
            CurrentPage.As<DashBoardPage>().Optionsheader();
            Console.WriteLine("Option bar Appeared");
            CurrentPage.As<DashBoardPage>().ClickMyDashboard();

        }

        [When(@"User clicks on ClickNews section to validate Message board")]
        public void WhenUserClicksOnClickNewsSectionToValidateMessageBoard()
        {

            CurrentPage = GetInstance<NewsPage>();
            CurrentPage.As<NewsPage>().ClickNews();
            Console.WriteLine("NewsSection Clicked");
        }

        [When(@"User clicks on Recent Activities button to validate Recent vacancies available")]
        public void WhenUserClicksOnRecentActivitiesButtonToValidateRecentVacanciesAvailable()
        {
            CurrentPage = GetInstance<MyRecentActivity>();
            CurrentPage.As<MyRecentActivity>().ClickRecentActivities();
   
            Console.WriteLine("RecentActivities Clicked");

        }

        [Then(@"User closed the browser")]
        public void ThenUserClosedTheBrowser()
        {
            DriverContext.Driver.Close();
            Console.WriteLine("Driver Closed");
        }

    }
}
