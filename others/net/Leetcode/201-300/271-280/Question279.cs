using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Perfect Squares
    /// https://leetcode.com/problems/perfect-squares/
    ///
    /// Given a positive integer n, find the least number of perfect square numbers (for example, 1, 4, 9, 16, ...) which sum to n.
    /// For example, given n = 12, return 3 because 12 = 4 + 4 + 4; given n = 13, return 2 because 13 = 4 + 9.
    /// </summary>
    public class Question279
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(NumSquares(-1));
            Program.PrintLine();
            Console.WriteLine(NumSquares(0));
            Program.PrintLine();
            Console.WriteLine(NumSquares(1));
            Program.PrintLine();
            Console.WriteLine(NumSquares(5));
            Program.PrintLine();
            Console.WriteLine(NumSquares(12));
            Program.PrintLine();
            Console.WriteLine(NumSquares(13));
            Program.PrintLine();
            Console.WriteLine(NumSquares(16));
        }

        public static int NumSquares(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int num = (int)Math.Sqrt(n);

            if (num * num == n)
            {
                return 1;
            }

            int[] result = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                result[i] = Int32.MaxValue;
            }

            result[0] = 0;

            for (int i = 1; i * i <= n; i++)
            {
                result[i * i] = 1;

                for (int j = i * i + 1; j <= n; j++)
                {
                    result[j] = Math.Min(result[j], result[j - i * i] + 1);
                }
            }

            return result[n];
        }
    }
}