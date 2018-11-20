﻿using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;

namespace Unit.Tests
{
    [TestClass]
    [TestCategory("unit")]
    public class WebDriverFactoryTests
    {
        private string _testBrowser = "chrome";
        private string _testBrowserVersion = "latest";
        private string _testOS = "Windows 10";
        private string _testBuildName = "testBuildName";
        private DriverFactory _factory;

        [TestInitialize]
        public void Setup()
        {
            _factory = new DriverFactory();
        }
        [TestMethod]
        public void ShouldNotBeNull()
        {
            _factory.Should().NotBeNull("Should have been initialized");
        }
        [TestMethod]
        public void ShouldReturnDriver()
        {
            var driver = _factory.CreateRemoteDriver(_testBrowser, _testBrowserVersion, _testOS);
            driver.Should().NotBeNull("The factory should instantiate a remote browser");
        }
        [TestMethod]
        public void ShouldReturnIDriver()
        {
            var driver = _factory.Create(_testBrowser, _testBrowserVersion, _testOS);
            driver.Should().BeOfType(typeof(RemoteDriver));
        }
        [TestMethod]
        public void ShouldReturnDriverWithSauceCapsPassedIn()
        {
            var driver = _factory.Create(_testBrowser, _testBrowserVersion, _testOS);
            driver.Should().BeOfType(typeof(RemoteDriver));
        }
        //[TestMethod]
        //public void ShouldReturnRemoteWebDriver()
        //{
        //    var factory = new WebDriverFactory();
        //    var sauceCapabilities = new SauceLabsCapabilities();
        //    var driver = GetSauceDriver(factory, sauceCapabilities);
        //    driver.Should().NotBeNull();
        //}

        //private RemoteWebDriver GetSauceDriver(WebDriverFactory factory, SauceLabsCapabilities sauceCapabilities)
        //{
        //    return factory.CreateSauceDriver(_testBrowser, _testBrowserVersion, _testOS, sauceCapabilities);
        //}

        //[TestMethod]
        //public void ShouldReturnRemoteWebDriverWithBuildName()
        //{
        //    var factory = new WebDriverFactory();
        //    var sauceCapabilities = new SauceLabsCapabilities();
        //    SauceLabsCapabilities.BuildName = _testBuildName;
        //    var driver = GetSauceDriver(factory, sauceCapabilities);
        //    driver.Capabilities.HasCapability("build").Should().BeTrue();
        //    driver.Capabilities.GetCapability("build").Should().BeEquivalentTo(_testBuildName);
        //}
        //[TestMethod]
        //public void ShouldBeInitialized()
        //{
        //    var sauceCapabilities = new SauceLabsCapabilities();
        //    var factory = new WebDriverFactory(sauceCapabilities);
        //    var driver = GetSauceDriver(factory, sauceCapabilities);
        //    driver.Should().NotBeNull("the driver should be initialized");
        //}
        //[TestMethod]
        //public void ShouldReturnRemoteWebDriverWithBrowserOsAndVersion()
        //{

        //    var factory = new WebDriverFactory();
        //    var sauceCapabilities = new SauceLabsCapabilities();
        //    var driver = GetSauceDriver(factory, sauceCapabilities);
        //    driver.Capabilities.GetCapability(CapabilityType.BrowserName).
        //        Should().BeEquivalentTo(_testBrowser);
        //    driver.Capabilities.GetCapability(CapabilityType.BrowserVersion).
        //        Should().BeEquivalentTo(_testBrowserVersion);
        //    driver.Capabilities.GetCapability(CapabilityType.Platform).
        //        Should().BeEquivalentTo(_testOS);
        //}
    }
}
