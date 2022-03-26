using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumFirst
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            //(IwebDriver is an Interface) 
            //methods (geturl,click) is declared but doesn't show the implementation

            //Chromedriver.exe on chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //[namespace.class.method of this class]

            driver = new ChromeDriver();


            /* new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
             * 
             * new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            WeDriverManager-(

            driver =new FirefoxDriver();
            driver new = edgeDriver()
            */

            driver.Manage().Window.Maximize(); /* without bracket is an property

            I means interface (IWebDriver)*/
        
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://nhdrasel.wordpress.com";
            TestContext.Progress.WriteLine(driver.Url);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close(); // Brackets () means method 
            
            //driver.Quit();  //close all pages [] | 2 or more
        }
    }
}
