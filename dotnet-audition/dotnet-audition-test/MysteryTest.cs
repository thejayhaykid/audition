using dotnet_audition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_audition_test
{
    [TestClass]
    public class MysteryTest
    {
        [TestMethod]
        public void TestMystery()
        {
            var num = "1000";
            var expNum = "1,000";
            var mystery = new MysteryClass();


            Assert.AreEqual(mystery.Mystery(num), expNum);
        }

        [TestMethod]
        public void TestMystery2()
        {
            var num = "1000000";
            var expNum = "1,000,000";
            var mystery = new MysteryClass();


            Assert.AreEqual(mystery.Mystery(num), expNum);
        }

        [TestMethod]
        public void TestMystery3()
        {
            var num = "100";
            var expNum = "100";
            var mystery = new MysteryClass();


            Assert.AreEqual(mystery.Mystery(num), expNum);
        }

        [TestMethod]
        public void TestMystery4()
        {
            var num = "10";
            var expNum = "10";
            var mystery = new MysteryClass();


            Assert.AreEqual(mystery.Mystery(num), expNum);
        }
    }
}
