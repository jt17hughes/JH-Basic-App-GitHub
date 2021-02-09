using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            JH_Basic_App_GitHub.Class1 tp = new JH_Basic_App_GitHub.Class1();
            Assert.AreEqual(tp.Name, "Justin Hughes - The Code Master");
        }
    }
}
