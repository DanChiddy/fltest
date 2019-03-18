using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace TestAnalystRecruitmentTest
{
    class WeatherPage : Base
    {


        public WeatherPage()
        {
            PageFactory.InitElements(driver, this);
        }

    }
}
