using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TestStack.BDDfy.Reporters.Html;

namespace MakemyTrip_Project_Specflow.Pages
{
    class GenerateExtentReport
    {
        private static ExtentReports extentReports;
        public static ExtentHtmlReporter htmlReporter;

        private GenerateExtentReport()
        {

        }

        public static ExtentReports getInstance()
        {
            if(extentReports==null)
            {
                string Reportpath = @"D:\Personal Practice Projects\MakemyTrip Project\MakemyTrip Project Specflow\MakemyTrip Project Specflow\ExtentReports\Reports.html";
                htmlReporter = new ExtentHtmlReporter(Reportpath);
                extentReports = new ExtentReports();
               extentReports.AttachReporter(htmlReporter);
                extentReports.AddSystemInfo("OS", "Windows");
                extentReports.AddSystemInfo("Host Name","NIRANJANA");
                extentReports.AddSystemInfo("Host Name", "NIRANJANA");
                extentReports.AddSystemInfo("Environment","QA");
                extentReports.AddSystemInfo("UserName","sid");

                string extentconfigpath = @"D:\Personal Practice Projects\MakemyTrip Project\MakemyTrip Project Specflow\MakemyTrip Project Specflow\ExtentReports\extentreportsconf.xml";
                htmlReporter.LoadConfig(extentconfigpath);
            }

            return extentReports;
        }
    }
}
