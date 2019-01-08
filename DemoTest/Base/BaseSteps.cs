using DemoTest.Config;
using DemoTest.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoTest.Base
{
    public abstract class BaseStep : Base
 
        {

            public virtual void NaviateSite()
            {
                DriverContext.Browser.GoToUrl(Settings.AUT);
                LogHelpers.Write("Opened the browser !!!");
            }
        }
    }

