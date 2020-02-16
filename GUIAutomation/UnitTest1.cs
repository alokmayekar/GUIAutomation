using GUIAutomation.HelperClasses;
using GUIAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace GUIAutomation
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            //Navigate to Amazon Home Page
            NavigationHelper.NavigateToURL("https://www.amazon.in/");

            //Search Iphone 11
            HomePage homePage = new HomePage();
            homePage.IsSearchBoxDisplayed();
            homePage.EnterSearchText("Iphone 11");
            Thread.Sleep(1000);
            homePage.ClickSearchIcon();

            //Take screenshot
            GenericHelper.TakeScreenshot();
        }
    }
}
