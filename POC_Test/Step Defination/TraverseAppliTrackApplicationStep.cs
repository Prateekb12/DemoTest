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
    class TraverseAppliTrackApplication : BasePage
    {
        LoginPage loginPage = new LoginPage();
        [Given(@"User has entered the correct application url on browser")]
        public void GivenUserHasEnteredTheCorrectApplicationUrlOnBrowser()
        {
            string url = "https://www.applitrack.com/dex/";
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
        }

        [Given(@"the application is loaded correctly")]
        public void GivenTheApplicationIsLoadedCorrectly()
        {
            DriverContext.Driver.Manage().Window.Maximize();
        }

        [When(@"User entered correct Username and Password")]
        public void WhenUserEnteredCorrectUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login(data.Username, data.Password);
        }

       

        [When(@"User clicks on MyDashbard icon to visit News and Activitis section")]
        public void WhenUserClicksOnMyDashbardIconToVisitNewsAndActivitisSection()
        {
            DashBoardPage dashBoardPage = loginPage.ClickLogin();
            dashBoardPage.BannerName();

        }

        [When(@"User clicks on ClickNews section to validate Message board")]
        public void WhenUserClicksOnClickNewsSectionToValidateMessageBoard()
        {
            DashBoardPage dashBoardPage = new DashBoardPage();
            NewsPage newsPage = dashBoardPage.ClickMyDashboard();
        }

        [When(@"User clicks on Recent Activities button to validate Recent vacancies available")]
        public void WhenUserClicksOnRecentActivitiesButtonToValidateRecentVacanciesAvailable()
        {
            NewsPage newsPage = new NewsPage();
            MyRecentActivity myRecentActivity = newsPage.ClickNews();
            myRecentActivity.ClickRecentActivities();
        }

    }
}
