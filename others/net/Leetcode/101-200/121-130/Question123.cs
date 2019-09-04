using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Best Time to Buy and Sell Stock III
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
    ///
    /// Say you have an array for which the ith element is the price of a given stock on day i.
    /// Design an algorithm to find the maximum profit. You may complete at most two transactions.
    ///
    /// Note:
    /// You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
    ///
    /// Assumptions:
    /// You must at first buy the stock and moving forward sell the stock before you buy again.
    ///
    /// Example:-
    /// Input - [3,3,5,0,0,3,1,4]
    /// Output - 6
    ///
    /// Explanation - The transactions to maximize profit are (5-3) + (4-0) = 6
    /// </summary>
    public class Question123
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 }));
            Program.PrintLine();
            Console.WriteLine(MaxProfit(new int[] { 1, 2, 3, 4, 5 }));
        }

        public static int MaxProfit(int[] prices)
        {
            int result = 0;

            if (prices != null && prices.Length > 1)
            {
                int[] left = new int[prices.Length];
                int[] right = new int[prices.Length];

                left[0] = 0;
                int min = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    min = Math.Min(min, prices[i]);
                    left[i] = Math.Max(left[i - 1], prices[i] - min);
                }

                right[prices.Length - 1] = 0;
                int max = prices[prices.Length - 1];
                for (int i = prices.Length - 2; i >= 0; i--)
                {
                    max = Math.Max(max, prices[i]);
                    right[i] = Math.Max(right[i + 1], max - prices[i]);
                }

                for (int i = 0; i < prices.Length; i++)
                {
                    result = Math.Max(result, left[i] + right[i]);
                }
            }

            return result;
        }
    }
}