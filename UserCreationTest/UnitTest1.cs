using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NotlyNote;

namespace UserCreationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testUser = new MyUser("Ricardo", "Carvalheira", "Password", "Ricardo.carvalheira@test.com");
            var result = testUser.IsEmailValid();
            Assert.AreEqual(true, result);
        }
    }
}
