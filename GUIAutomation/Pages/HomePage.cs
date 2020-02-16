using GUIAutomation.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
