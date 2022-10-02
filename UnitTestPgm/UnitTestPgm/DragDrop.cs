using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestPgm
{
    [TestClass]
    public class DoubleClick
    {

       public  IWebDriver driver;
        [TestInitialize]
        public  void Initalization()
        {
            driver = new ChromeDriver(); //Run Time polymorphism
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/simple_context_menu.html");
           
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(7000);

          IWebElement DoubleClickButton=  driver.FindElement(By.XPath("//button[text()='Double-Click Me To See Alert']"));

           

            Actions act = new Actions(driver);

            act.DoubleClick(DoubleClickButton).Perform(); //Alert popup is open
            Thread.Sleep(4000);

          IAlert alrt =   driver.SwitchTo().Alert();

            Console.WriteLine(alrt.Text);

            alrt.Accept(); //click on ok button

            // alrt.Dismiss(); //cancel button
            Thread.Sleep(4000);


        }
       

        [TestCleanup]
        public  void CLeanUp()
        {
            driver.Close();
        }
    }
}