using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        UserLogin obj = new UserLogin();

        [TestMethod]
        [DataTestMethod]
        [DataRow("Aam","aadmi")]
        [DataRow("Mango","Man")]
        [DataRow("admin","Admin123")]
        [DataRow("Admin","admin123")]
        [DataRow("Admin", "Admin123")]
        public void TestUser(string user,string pass)
        {
            bool output = obj.login(user, pass);
            
            Assert.AreEqual(true,output);
            
        }
    }
}
