using OpenQA.Selenium;

namespace Pages.Pages
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