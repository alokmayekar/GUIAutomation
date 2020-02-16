using GUIAutomation.CommonObjects;

namespace GUIAutomation.HelperClasses
{
    public class NavigationHelper
    {
        public static void NavigateToURL(string url)
        {
            CommonRepository.Driver.Navigate().GoToUrl(url);
        }
    }
}
