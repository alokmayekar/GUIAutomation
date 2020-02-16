using GUIAutomation.CommonObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIAutomation.Exceptions
{
    public class NoElementFoundException : Exception
    {
        public NoElementFoundException(By locator):base()
        {
            Console.WriteLine("No such element exists:- {0}", locator.ToString());
        }
    }
}
