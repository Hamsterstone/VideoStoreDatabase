using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStoreDatabase;
using System.Windows.Forms;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //set up local Database and Form1 for testing
        private Database fakeDatabase = new Database();
        Form1 fakeForm = new Form1();

        //Test method tests that program connects to the database
        [TestMethod]
        public void TestConnection()
        {
            Assert.IsTrue(fakeDatabase.UnitTestConnection());
        }
        //Test method checks Form1.IsOldEnough
        [TestMethod]
        public void TestIsOldEnough()
        {
            //set up datetimes for an over and an under 18 return
            DateTime over18 = new DateTime(1990, 1, 1);
            DateTime under18 = new DateTime(2005, 1, 1);//revisit date in 2020 to avoid bugs
            //rating that requires over 18 customer
            string rating = "M";
            //check IsOldEnough returns true for over 18, false for under.
            Assert.IsTrue(fakeForm.IsOldEnough(over18, rating));
            Assert.IsFalse(fakeForm.IsOldEnough(under18, rating));
        }
        //Test method checks Form1.RentalCalculator
        [TestMethod]
        public void TestRentalCalculator()
        {
            //set up "movie years" older and newer than 5 years.
            string year5 = "2015";//revisit in 2018 to avoid bugs
            string year2 = "2000";
            //set up expected return values
            int expectedValue5 = 5;
            int expectedValue2 = 2;
            //check RentalCalculator returns expected values
            Assert.AreEqual(expectedValue5,fakeForm.RentalCalculator(year5));
            Assert.AreEqual(expectedValue2, fakeForm.RentalCalculator(year2));
        }
    }
}
