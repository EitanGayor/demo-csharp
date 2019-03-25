using System.Reflection;
using Common;
using NUnit.Framework;

namespace SeleniumNunit.SaucePerformance
{
    [TestFixture]
    public class PerformanceExample
    {
        [Test]
        public void Test()
        {
            var driver = new WebDriverFactory().
                CreateSauceDriver(MethodBase.GetCurrentMethod().Name);
            //new SauceDemoLoginPage(driver);
            //new CheckoutCompletePage(driver);
        }
    }
}
