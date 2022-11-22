using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestDotNetApp;

namespace TestDotNetAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            bool r = false;
            Console.WriteLine("Executing add method...");
            Program pObj = new Program();
            var result = pObj.add(1, 1);
            if (result > 0)
                r = true;
            else
                r = false;

            Assert.AreEqual(true, r);
            
        }

        [TestMethod]
        public void TestMulty()
        {
            bool r = false;
            Console.WriteLine("Executing multiplication method...");
            Program pObj = new Program();
            var result = pObj.multiplication(1, 11);
            if (result > 0)
                r = true;
            else
                r = false;

            Assert.AreEqual(true, r);

        }
    }
}
