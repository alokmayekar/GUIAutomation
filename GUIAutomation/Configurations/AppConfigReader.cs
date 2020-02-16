using GUIAutomation.CommonObjects;
using System;
using System.Configuration;

namespace GUIAutomation.Configurations
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browserType = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
    }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }
    }
}
