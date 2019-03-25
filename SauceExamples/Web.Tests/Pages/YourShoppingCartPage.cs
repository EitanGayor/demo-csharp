using OpenQA.Selenium;

namespace Web.Tests.Pages
{
    internal class YourShoppingCartPage : BasePage
    {
        public YourShoppingCartPage(IWebDriver driver) : base(driver)
        {
        }

        internal CheckoutInformationPage Checkout()
        {
            Wait.UntilIsVisibleByCss("a[class='btn_action checkout_button']").Click();
            return new CheckoutInformationPage(_driver);
        }
    }
}