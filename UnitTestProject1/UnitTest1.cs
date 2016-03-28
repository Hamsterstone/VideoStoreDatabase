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
        public void TestMethod1()
        {
            Assert.IsTrue(fakeDatabase.UnitTestConnection());
        }
    }
}
