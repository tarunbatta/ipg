using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Smallest Good Base
    /// https://leetcode.com/contest/leetcode-weekly-contest-16b/problems/smallest-good-base/
    ///
    /// For an integer n, we call k>=2 a good base of n, if all digits of n base k are 1.
    /// Now given a string representing n, you should return the smallest good base of n in string format.
    ///
    /// Example 1:
    /// Input: "13"
    /// Output: "3"
    /// Explanation: 13 base 3 is 111.
    ///
    /// Example 2:
    /// Input: "4681"
    /// Output: "8"
    /// Explanation: 4681 base 8 is 11111.
    ///
    /// Example 3:
    /// Input: "1000000000000000000"
    /// Output: "999999999999999999"
    /// Explanation: 1000000000000000000 base 999999999999999999 is 11.
    ///
    /// Note:
    /// The range of n is [3, 10^18].
    /// The string representing n is always valid and will not have leading zeros.
    /// </summary>
    public class Question483
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(SmallestGoodBases(null));
            Program.PrintLine();
            Console.WriteLine(SmallestGoodBases("13"));
            Program.PrintLine();
            Console.WriteLine(SmallestGoodBases("4681"));
            Program.PrintLine();
            Console.WriteLine(SmallestGoodBases("1000000000000000000"));
        }

        public static string SmallestGoodBases(string n)
        {
            string result = null;

            if (!string.IsNullOrEmpty(n))
            {
                long num = Int64.Parse(n);
                long key = 0;

                // length
                for (long k = 60; k >= 2; k--)
                {
                    // base
                    long l = 2, h = num - 1;
                    while (l <= h)
                    {
                        long mid = l + (h - l) / 2;
                        double left = Math.Pow(mid, k) - 1;
                        long right = (long)num * (mid - 1);

                        if (left == right)
                        {
                            key = mid;
                            break;
                        }

                        if (left < right)
                        {
                            l = mid + 1;
                        }
                        else
                        {
                            h = mid - 1;
                        }
                    }

                    if (key != 0)
                    {
                        break;
                    }
                }

                result = key + "";
            }

            return result;
        }
    }
}