﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DemoTest.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;

            string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("DemoTest/RunSettings/AUT");
            buildname = navigator.SelectSingleNode("DemoTest/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("DemoTestRunSettings/TestType");
            islog = navigator.SelectSingleNode("DemoTest/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("DemoTest/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("DemoTest/RunSettings/LogPath");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();
        }

    }
}

