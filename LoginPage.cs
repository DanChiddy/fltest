using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAnalystRecruitmentTest
{
    class LoginPage : Base
    {
        [FindsBy(How = How.Id, Using = "username-input")]
        private IWebElement EmailAddressField;

        [FindsBy(How = How.Id, Using = "password-input")]
        private IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "submit-button")]
        private IWebElement LoginSubmitButton;


        public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public void EnterEmailAddress(string EmailAddress = "")
        {
            EmailAddressField.SendKeys(EmailAddress);
        }

        public void EnterPassword(string Password = "")
        {
            PasswordField.SendKeys(Password);
        }

        public void ClickSubmitButton()
        {
            LoginSubmitButton.Click();
        }

        public HomePage Login(string EmailAddress = "", string Password = "")
        {
            //COMPLETE THE STEPS FOR THE LOGIN HERE USING THE ABOVE PAGE OBJECTS (
            // ie. user enters an email address, user enters a password and then clicks submit)
        }
    }
}
