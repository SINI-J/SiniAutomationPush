using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestPgm
{
    [TestClass]
    public class OpenBrowser
    {

       public  IWebDriver driver;
        [TestInitialize]
        public  void Initalization()
        {
            driver = new ChromeDriver(); //Run Time polymorphism
            driver.Navigate().GoToUrl("https://www.facebook.com");
           
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(9000);
            
            Console.WriteLine(driver.Title);
            //  driver.FindElement(By.Name("q")).SendKeys("Testing");
            driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");

            driver.FindElement(By.Name("pass")).SendKeys("1234566");

            driver.FindElement(By.Name("login")).Click();
            Thread.Sleep(3000);
        }
       

        [TestCleanup]
        public  void CLeanUp()
        {
            driver.Close();
        }
    }
}