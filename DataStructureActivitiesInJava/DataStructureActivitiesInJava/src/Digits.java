public class Digits {
    /// <summary>
        /// This function accepts an integer and returns the sum of all its digits
        /// </summary>
        /// <param name="n"> n > -1 ||</param>
        /// <returns></returns>
        public static int AddDigits(int n)
        {
            var digits = String.valueOf(n).toCharArray();

            int sum = 0;

            for (int i = 0; i < digits.length; i++)
            {
                // 123 = 6  /// digits [1][2][3]
                // indices:             0  1  2
                sum = sum + Integer.parseInt(String.valueOf(digits[i]));
            }       

            return sum;
        }

        public static int LargestNumber(int n)
        { 
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
