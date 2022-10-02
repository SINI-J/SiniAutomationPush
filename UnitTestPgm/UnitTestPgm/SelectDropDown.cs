using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace UnitTestPgm
{
    [TestClass]
    public class SelectDropDown

    {

       public  IWebDriver driver;
        [TestInitialize]
        public  void Initalization()
        {
            driver = new ChromeDriver(); //Run Time polymorphism
            driver.Navigate().GoToUrl("https://www.amazon.com");
           
        }

      //  [TestMethod]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(2000);

            IWebElement dropdown = driver.FindElement(By.Id("searchDropdownBox"));

            SelectElement sel = new SelectElement(dropdown);
            sel.SelectByIndex(5);
            sel.SelectByValue("search-alias=sporting-intl-ship");

            sel.SelectByText("Video Games");

           
        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Manage().Window.Maximize(); //maximize the window

            Thread.Sleep(2000);

            IWebElement dropdown = driver.FindElement(By.Id("searchDropdownBox")); //Interface

            SelectElement sel = new SelectElement(dropdown);

            IList<IWebElement> seloptionvalue = sel.Options;

            Console.WriteLine(seloptionvalue.Count);

            for(int i = 0; i<seloptionvalue.Count; i++) // 0 0<=27
            {
                seloptionvalue[i].Click();


                Console.WriteLine(seloptionvalue[i].Text);//
            }

           IList<IWebElement> li = driver.FindElements(By.XPath(""));



            




        }


        [TestCleanup]
        public  void CLeanUp()
        {
          //  driver.Close();
        }
    }
}