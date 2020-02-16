using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIAutomation.HelperClasses
{
    public class InputBoxHelper
    {
        public static void EnterText(By locator, string inputText)
        {
            GenericHelper.GetElement(locator).SendKeys(inputText);
        }
    }
}
