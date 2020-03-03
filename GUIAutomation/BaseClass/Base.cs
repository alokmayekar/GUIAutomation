using GUIAutomation.CommonObjects;
using GUIAutomation.Configurations;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace GUIAutomation.BaseClass
{
    public class Base
    {
        [SetUp]
        public static void InitializeWebDriver()
        {
            CommonRepository.Config = new AppConfigReader();
            switch (CommonRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    CommonRepository.Driver = new ChromeDriver(ChromeDriverOptions());
                    break;
                case BrowserType.Firefox:
                    CommonRepository.Driver = new FirefoxDriver();
                    CommonRepository.Driver.Manage().Window.Maximize();
                    break;
                case BrowserType.InternetExplorer:
                    CommonRepository.Driver = new InternetExplorerDriver();
                    CommonRepository.Driver.Manage().Window.Maximize();
                    break;
                default:
                    Console.WriteLine("Invalid driver");
                    break;
            }
            CommonRepository.UserName = CommonRepository.Config.GetUserName();
            CommonRepository.Password = CommonRepository.Config.GetPassword();
            CommonRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
        }

        public static ChromeOptions ChromeDriverOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Eager;
            return chromeOptions;
        }

        [TearDown]
        public static void TearDownWebDriver()
        {
            Thread.Sleep(2000);
            if (CommonRepository.Driver != null)
            {
                CommonRepository.Driver.Quit();
            }
        }
    }
}
