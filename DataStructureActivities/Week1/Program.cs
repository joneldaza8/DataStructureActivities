using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 1 activity!");
        }
    }

    public class Digits
    {
        /// <summary>
        /// This function accepts an integer and returns the sum of all its digits
        /// </summary>
        /// <param name="n"> n > -1 ||</param>
        /// <returns></returns>
        public static int AddDigits(int n)
        {
            // todo: do your magic here! :)
 {
        static void Main(string[] args)
           {
            int n = 29, remainder, sum = 0;
            int n1 = 123, remainder1, sum1 = 0;
            int n2 = 527, remainder2, sum2 = 0;
            int n3 = 123456, remainder3, sum3 = 0;

            while( n > 0)
            while( n1 > 0)
            while( n2 > 0)
            while( n3 > 0)
            {
                remainder = n % 10;
                remainder1 = n1 % 10;
                remainder2 = n2 % 10;
                remainder3 = n3 % 10;

                sum = sum + remainder;
                sum1 = sum1 + remainder1;
                sum2 = sum2 + remainder2;
                sum3 = sum3 + remainder3;

                n = n / 10;
                n1 = n1 / 10;
                n2 = n2 / 10;
                n3 = n3 / 10;
            }
            Console.WriteLine("AddDigits(n) is {0}", sum);
            Console.WriteLine("AddDigits(n) is {0}", sum1);
            Console.WriteLine("AddDigits(n) is {0}", sum2);
            Console.WriteLine("AddDigits(n) is {0}", sum3);
        }
            return 0;
        }

        public static int LargestNumber(int n)
        {
            // todo: do your magic here! :)

            return 0;
        }

        public static int OptimalEqualSplit(int n, int m)
        {
            // todo: do your magic here! :)

            return 0;
        }

        public static int Persistence(int n)
        {
            // todo: do your magic here! :)

            return 0;
        }
    }
}
