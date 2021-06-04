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
        [DataRow("Admin", "admin123")]
        public void TestUser(string user, string pass)
        {
            bool actual = obj.login(user, pass);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Aam", "aadmi")]
        [DataRow("Mango", "Man")]
        [DataRow("admin", "Admin123")]
        [DataRow("Admin", "Admin123")]
        public void TestWrongUserDetails(string user, string pass)
        {
            bool expected = false;
            if (user == "Admin" && pass == "admin123")
            {
                expected = true;
            }
            bool actual = obj.login(user, pass);
            Assert.AreEqual(expected, actual);
        }
    
        
    }
}
