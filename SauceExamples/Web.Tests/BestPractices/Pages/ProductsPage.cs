﻿using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Web.Tests.Antipatterns;

namespace Web.Tests.BestPractices.Pages
{
    public class ProductsPage
    {
        private readonly IWebDriver _driver;

        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;      
        }

        public bool IsLoaded => _driver.Url.Contains("/inventory.html");

        public void Logout()
        {
            HamburgerElement.Click();
            LogoutLink.Click();
        }

        public IWebElement LogoutLink => _driver.FindElement(By.Id("logout_sidebar_link"));

        public IWebElement HamburgerElement => _driver.FindElement(By.ClassName("bm-burger-button"));
        public int ProductCount => 
            _driver.FindElements(By.ClassName("inventory_item")).Count;

        public CartElement Cart => new CartElement(_driver);

        public void AddToCart(Item itemType)
        {
            
        }
    }
}