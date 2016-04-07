using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStoreDatabase;
using System.Windows.Forms;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Database fakeDatabase = new Database();
        Form1 fakeForm = new Form1();
        [TestMethod]
        public void TestConnection()
        {
            Assert.IsTrue(fakeDatabase.UnitTestConnection());
        }

        [TestMethod]
        public void TestIsOldEnough()
        {
            DateTime over18 = new DateTime(1990, 1, 1);
            DateTime under18 = new DateTime(2005, 1, 1);
            string rating = "M";
            Assert.IsTrue(fakeForm.IsOldEnough(over18, rating));
            Assert.IsFalse(fakeForm.IsOldEnough(under18, rating));
        }

        [TestMethod]
        public void TestRentalCalculator()
        {
            string year5 = "2015";
            string year2 = "2000";
            int expectedValue5 = 5;
            int expectedValue2 = 2;
            Assert.AreEqual(expectedValue5,fakeForm.RentalCalculator(year5));
            Assert.AreEqual(expectedValue2, fakeForm.RentalCalculator(year2));
        }
    }
}
