using GUIAutomation.HelperClasses;
using NUnit.Framework;
using OpenQA.Selenium;

namespace GUIAutomation.Pages
{
    public class HomePage
    {
        #region WebElements
        private By SearchInputBox = By.Id("twotabsearchtextbox");
        private By SearchIcon = By.XPath("//div[@class='nav-search-submit nav-sprite']/input");
        #endregion

        #region Actions
        public void IsSearchBoxDisplayed()
        {
            Assert.IsTrue(GenericHelper.IsElementDisplayed(SearchInputBox));
        }
        public void EnterSearchText(string serachItem)
        {
            InputBoxHelper.EnterText(SearchInputBox, serachItem);
        }

        public void ClickSearchIcon()
        {
            GenericHelper.ClickElement(SearchIcon);
        }
        #endregion

    }
}
