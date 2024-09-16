using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week2.Test
{
    [TestClass]
    public class BasicStatisticsTest
    {
        [DataTestMethod]
        [DataRow(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 640)]
        [DataRow(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 1137)]
        public void TestGetSum(int[] n, int expectedSum)
        {
            int sum = BasicStatistics.GetSum(n);
            Assert.AreEqual(expectedSum, sum);
        }

        [DataTestMethod]
        [DataRow(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 64.00)]
        [DataRow(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 75.80)]
        public void TestGetMean(int[] n, double expectedMean)
        {

            double mean = BasicStatistics.GetMean(n);
            Assert.AreEqual(expectedMean, mean);
        }

        [DataTestMethod]
        [DataRow(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 67)]
        [DataRow(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 87)]
        public void TestGetMedian(int[] n, int expectedMedian)
        {
            int median = BasicStatistics.GetMedian(n);
            Assert.AreEqual(expectedMedian, median);
        }

        [DataTestMethod]
        [DataRow(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 67)]
        [DataRow(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 90)]
        public void TestGetMode(int[] n, int expectedMode)
        {
            int mode = BasicStatistics.GetMode(n);
            Assert.AreEqual(expectedMode, mode);
        }

        [DataTestMethod]
        [DataRow(new int[] { 87, 67, 43, 45, 67, 34, 89, 54, 87, 67 }, 89)]
        [DataRow(new int[] { 92, 90, 84, 75, 68, 34, 56, 87, 44, 56, 92, 90, 91, 90, 88 }, 92)]
        public void TestGetMaxValue(int[] n, int expectedMode)
        {
            int mode = BasicStatistics.GetMaxValue(n);
            Assert.AreEqual(expectedMode, mode);
        }
    }
}
