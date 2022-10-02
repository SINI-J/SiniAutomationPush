using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestPgm
{
    [TestClass]
    public class FrameHandling
    {

       public  IWebDriver driver;
        [TestInitialize]
        public  void Initalization()
        {
            driver = new ChromeDriver(); //Run Time polymorphism
            driver.Navigate().GoToUrl("https://demoqa.com/frames");
           
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            driver.SwitchTo().Frame("frame1"); //user going inside into the frame

            Thread.Sleep(2000);

            String TextValue = driver.FindElement(By.Id("sampleHeading")).Text;
            Console.WriteLine(TextValue);

            driver.SwitchTo().DefaultContent(); //come out from the frame

            driver.FindElement(By.XPath("//div[text()='Elements']")).Click();

           
        }
       

        [TestCleanup]
        public  void CLeanUp()
        {
            driver.Close();
        }
    }
}