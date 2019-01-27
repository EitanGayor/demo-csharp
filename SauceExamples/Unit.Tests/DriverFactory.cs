using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace Unit.Tests
{
    public class DriverFactory
    {
        public IDriver CreateRemoteDriver(string testBrowser, string testBrowserVersion, string testOs)
        {
            return new RemoteDriver(testBrowser, testBrowserVersion, testOs);
        }

        public IDriver Create(string testBrowser, string testBrowserVersion, string testOs)
        {
            return new RemoteDriver(testBrowser, testBrowserVersion, testOs);
        }

        internal RemoteWebDriver CreateRemoteDriver(RemoteType sauceLabs)
        {
            return new SauceEdgeBrowser().Get();
        }
    }

    internal class SauceEdgeBrowser
    {
        public SauceEdgeBrowser()
        {
            var sauceUserName = Environment.GetEnvironmentVariable("SAUCE_USERNAME", EnvironmentVariableTarget.User);
            //TODO please supply your own Sauce Labs access Key in an environment variable
            var sauceAccessKey = Environment.GetEnvironmentVariable("SAUCE_ACCESS_KEY", EnvironmentVariableTarget.User);

            var options = new EdgeOptions()
            {
                BrowserVersion = "latest",
                PlatformName = "Windows 10"
            };

            var sauceOptions = new Dictionary<string, object>
            {
                ["username"] = sauceUserName, ["accessKey"] = sauceAccessKey
            };

            options.AddAdditionalCapability("sauce:options", sauceOptions);
        }

        public RemoteWebDriver Get()
        {
            return new RemoteWebDriver(new Uri("https://ondemand.saucelabs.com/wd/hub"), options.ToCapabilities(),
                TimeSpan.FromSeconds(600));
        }

        public DriverOptions options { get; set; }
    }
}