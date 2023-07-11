using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Launch.StepDefinitions
{


    [Binding]
    public sealed class LaunchStepDefinitions
    {

        private IWebDriver driver;

        [Given(@"open the browsers")]
        public void GivenOpenTheBrowsers()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

    }
}