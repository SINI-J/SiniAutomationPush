using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestPgm
{
    [TestClass]
    public class MouseHovering
    {

       public  IWebDriver driver;
        [TestInitialize]
        public  void Initalization()
        {
            driver = new ChromeDriver(); //Run Time polymorphism
            driver.Navigate().GoToUrl("https://www.amazon.com");

           
           
        }

       /* [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(2000);

            IWebElement accountlist = driver.FindElement(By.XPath("//span[text()='Account & Lists']"));

            Actions act = new Actions(driver);

            act.MoveToElement(accountlist).Perform();

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//span[text()='Account']")).Click();
           
        }*/

        [TestMethod]
        public void HoveringMultipleList()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(2000);

            IWebElement accountlist = driver.FindElement(By.XPath("//span[text()='Account & Lists']"));

            Actions act = new Actions(driver);

            act.MoveToElement(accountlist).Perform();

            Thread.Sleep(3000);

            //driver.FindElement(By.XPath("//span[text()='Account']")).Click();

            //  IList<IWebElement> hoevringelement = driver.FindElements(By.XPath("//div[@class='nav-title'] | //a[@class='nav-link nav-item']"));

            IList<IWebElement> hoevringelement = driver.FindElements(By.XPath("//a[@class='nav-link nav-item']"));
           
            Console.WriteLine(hoevringelement.Count);
            for(int i = 0; i< hoevringelement.Count;i++)
            {
                
                hoevringelement[i].Click();
                hoevringelement = driver.FindElements(By.XPath("//a[@class='nav-link nav-item']"));
                driver.Navigate().Back();
                
                Thread.Sleep(3000);
                IWebElement accountlist1 = driver.FindElement(By.XPath("//span[text()='Account & Lists']"));

                Actions act1 = new Actions(driver);

                act1.MoveToElement(accountlist1).Perform();

                Thread.Sleep(3000);
                //Console.WriteLine(hoevringelement[i].Text);
            }

        }


        [TestCleanup]
        public  void CLeanUp()
        {
            driver.Close();
        }
    }
}