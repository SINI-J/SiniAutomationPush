using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPgm
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initalization()
        {
            Console.WriteLine("Browser Should Open with URL");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("calling Test Method1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Calling Test Method 2");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Calling Test Method 3");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("Calling Test Method 4");
        }

        [TestCleanup]
        public void CLeanUp()
        {
            Console.WriteLine("Close Browser");
        }
    }
}