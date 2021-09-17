using System;

namespace Week2
{
    public class BasicStatistics
    {
        public static decimal GetMean(int[] n)
        {
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
                sum += n[i];

            decimal mean = (decimal)sum / (decimal)n.Length;

            return Math.Round(mean, 2);
        }
    }
}
