using GUIAutomation.Configurations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIAutomation.CommonObjects
{
    public class CommonRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        public static string UserName { get; set; }
        public static string Password { get; set; }
    }
}
