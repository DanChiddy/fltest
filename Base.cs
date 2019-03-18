using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System.Drawing;

namespace TestAnalystRecruitmentTest
{
    public class Base
    {
        protected static IWebDriver driver;
        private FirefoxProfile _ffp;

        public IWebDriver StartBrowser(string browser)
        {
            //driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

            switch (browser)
            {
                //case "firefox":
                //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                //driver = new FirefoxDriver(service);
                //driver.Manage().Window.Size = new Size(1200, 1000);
                case "iexplore":
                    var options = new InternetExplorerOptions();
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    driver = new InternetExplorerDriver(@"C:\FundsLibrary\Test\SeleniumTests\Test.CoreFiles\packages\Selenium.WebDriver.IEDriver.3.3.0\driver");
                    break;
                case "chrome":
                    driver = new ChromeDriver(@"C:\FundsLibrary\Test\SeleniumTests\Test.CoreFiles\packages\Selenium.WebDriver.ChromeDriver.2.28.0\driver");
                    driver.Manage().Window.Size = new Size(1800, 1000);
                    break;
                case "phantom":
                    driver = new PhantomJSDriver(@"C:\FundsLibrary\Test\SeleniumTests\Test.CoreFiles\packages\PhantomJS.2.1.1\tools\phantomjs");
                    driver.Manage().Window.Size = new Size(1200, 1000);
                    break;
                default:
                    throw new InvalidOperationException("SeleniumDriver not set in config");
                    break;
            }
            return driver;
        }

        public void NavigateTo(string url = "")
        {
            var navigateToThisUrl = BaseUrl + url;
            driver.Navigate().GoToUrl(navigateToThisUrl);
        }


        public bool IsElementDisplayed(IWebElement element, int withinMilliseconds)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}

