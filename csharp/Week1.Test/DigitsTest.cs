using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1.Test
{
    [TestClass]
    public class DigitsTest
    {
        [DataTestMethod]
        [DataRow(29,11)]
        [DataRow(123,6)]
        [DataRow(527,14)]
        [DataRow(123456,21)]
        public void TestAddDigits(int n, int expectedSum)
        {
            Assert.AreEqual(expectedSum, Digits.AddDigits(n));
        }

        [DataTestMethod]
        [DataRow(2, 99)]
        [DataRow(3, 999)]
        [DataRow(4, 9999)]
        [DataRow(5, 99999)]
        public void TestLargestNumber(int n, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Digits.LargestNumber(n));
        }

        [DataTestMethod]
        [DataRow(3, 10, 9)]
        [DataRow(1, 2, 2)]
        [DataRow(10, 5, 0)]
        [DataRow(4, 4, 4)]
        [DataRow(4, 15, 12)]
        public void TestOptimalEqualSplit(int n, int m, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Digits.OptimalEqualSplit(n,m));
        }

        [DataTestMethod]
        [DataRow(39, 3)]
        [DataRow(4, 0)]
        [DataRow(25,2)]
        [DataRow(999, 4)]
        public void TestPersistence(int n, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Digits.Persistence(n));
        }


    }
}
