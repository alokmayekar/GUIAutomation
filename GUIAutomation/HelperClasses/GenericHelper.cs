using GUIAutomation.CommonObjects;
using GUIAutomation.Exceptions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace GUIAutomation.HelperClasses
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return CommonRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return CommonRepository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoElementFoundException(locator);
            }
        }

        public static bool IsElementDisplayed(By locator)
        {
            var element = GetElement(locator);
            if (element.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void TakeScreenshot()
        {
            string currentDate = "E:\\C#\\Automation\\Screenshots\\SampleTest" + DateTime.UtcNow.ToString("dd-MM-yyyy-HH-mm-ss");
            Screenshot screenshot = CommonRepository.Driver.TakeScreenshot();
            screenshot.SaveAsFile(currentDate + ".jpeg", ScreenshotImageFormat.Jpeg);
        }

        public static void ClickElement(By locator)
        {
            GetElement(locator).Click();
        }
    }
}
