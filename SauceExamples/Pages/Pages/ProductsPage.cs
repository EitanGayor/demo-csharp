﻿using OpenQA.Selenium;
using Pages.Elements;

namespace Pages.Pages
{
    public class ProductsPage : BasePage
    {
        private readonly string _pageUrlPart;

        public ProductsPage(IWebDriver driver) : base(driver)
        {
            _pageUrlPart = "inventory.html";
        }

        public bool IsLoaded => _driver.Url.Contains($"/{_pageUrlPart}");

        public IWebElement LogoutLink => _driver.FindElement(By.Id("logout_sidebar_link"));

        public IWebElement HamburgerElement => _driver.FindElement(By.ClassName("bm-burger-button"));

        public int ProductCount =>
            _driver.FindElements(By.ClassName("inventory_item")).Count;

        public CartElement Cart => new CartElement(_driver);

        public void Logout()
        {
            HamburgerElement.Click();
            LogoutLink.Click();
        }

        internal ProductsPage Open()
        {
            _driver.Navigate().GoToUrl($"{BaseUrl}/{_pageUrlPart}");
            return this;
        }

        public void AddToCart(Item itemType)
        {
            Wait.UntilIsVisibleByCss("button[class='btn_primary btn_inventory']").Click();
        }
    }
}