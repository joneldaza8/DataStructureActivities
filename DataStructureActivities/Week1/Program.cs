using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 1 activity!");
            int enteredNumber = int.Parse(Console.ReadLine());
            int number = Digits.AddDigits(enteredNumber);
            Console.WriteLine($"Result: {number}");
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
          
            var digits = n.ToString().ToCharArray();

            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                // 123 = 6  /// digits [1][2][3]
                // indices:             0  1  2
                sum = sum + int.Parse(digits[i].ToString());
            }       

            return sum;
        }

        public static int LargestNumber(int n)
        {  
            /*var num = Math.Pow(10, n) - 1;
            return (int)num;*/

            string highnumber = "";
            for (int i = 0; i < n; i++)
                highnumber += "9";
            
            return int.Parse(highnumber);
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


