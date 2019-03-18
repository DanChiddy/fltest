using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAnalystRecruitmentTest
{
    [TestClass]
    public class TestList : Base
    {
        [TestInitialize]
        public void SetupTest()
        {
            StartBrowser("Firefox");
            NavigateTo("");
        }

        [TestCategory("StableTestEnv"), TestMethod()]
        public void LoginAsAnExisingUser()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homePage = loginPage.Login("", "");
            //COMPLETE THE ASSERTATION TO CONFIRM LOGIN
        }

        [TestCategory("StableTestEnv"), TestMethod()]
        public void SearchForCurrentWeatherInBristol()
        {
            WeatherPage weatherPage = new WeatherPage();
            //COMPLETE THE CODE TO CALL THE TEST ON WEATHERPAGE.CS AND MAKE ASSERTATION
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
