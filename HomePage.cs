using System;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAnalystRecruitmentTest
{
    [TestClass]
    public class HomePage : Base
    {
        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
