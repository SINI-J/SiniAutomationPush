using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestPgm
{
    [TestClass]
    public class DragDrop
    {

       public  IWebDriver driver;
        [TestInitialize]
        public  void Initalization()
        {
            driver = new ChromeDriver(); //Run Time polymorphism
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/drag_drop.html");
           
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(7000);

          IWebElement startingpoint=  driver.FindElement(By.XPath("//a[text()=' BANK ']"));

            IWebElement target = driver.FindElement(By.Id("bank"));

            Actions act = new Actions(driver);

            act.DragAndDrop(startingpoint, target).Perform();
            Thread.Sleep(4000);

           
        }
       

        [TestCleanup]
        public  void CLeanUp()
        {
            driver.Close();
        }
    }
}