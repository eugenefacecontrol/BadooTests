﻿using BadooProject.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BadooProject.Pages
{
    public class RegisterPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//span[.='Войти']/parent::*/parent::*")]
        private IWebElement loginButton;

        public LoginPage GoToLoginPage()
        {
            loginButton.Click();
            return new LoginPage();
        }
    }
}