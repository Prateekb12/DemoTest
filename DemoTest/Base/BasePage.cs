using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.Base
{
    public abstract class BasePage : Base
    
        {
            public BasePage()
            {
                PageFactory.InitElements(DriverContext.Driver, this);
            }

        }
    }

