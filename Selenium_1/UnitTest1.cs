using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //create the reference for our browser
            driver = new ChromeDriver();

            //Navigate to the google page
            driver.Navigate().GoToUrl("https://www.google.com");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void Test1()
        { 
            //find the element
            driver.FindElement(By.Name("q")).SendKeys("Samaleti Chandu");
            driver.FindElement(By.XPath("(//input[@type='submit'])[3]")).Click();
            driver.FindElement(By.PartialLinkText("Chandu Samaleti")).Click();
            
            //Assert.Pass();
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}