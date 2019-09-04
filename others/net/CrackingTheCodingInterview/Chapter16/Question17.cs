﻿using System;

namespace TechByTarun.InterviewPreperationGuide.App.CrackingTheCodingInterview.Chapter16
{
    /// <summary>
    /// Contiguous Sequence:
    /// You are given an array of integers (both positive and negative).
    /// Find the contiguous sequence with the largest sum.
    /// Return the sum.
    ///
    /// EXAMPLE
    /// Input: 2, -8, 3, -2, 4, -10
    /// Output: 5 (i.e., { 3, -2, 4})
    /// </summary>
    public class Question17
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(GetLargesttSum(new int[] { 2, -8, 3, -2, 4, -10 }));
            Program.PrintLine();
            Console.WriteLine(GetLargesttSum(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }));
        }

        /// <summary>
        /// Kadane's algorithm
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetLargesttSum(int[] nums)
        {
            int result = 0;
            int maxSum = 0;

            if (nums != null && nums.Length > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    maxSum = maxSum + nums[i];

                    if (maxSum < 0)
                    {
                        maxSum = 0;
                    }

                    if (result < maxSum)
                    {
                        result = maxSum;
                    }
                }
            }

            return result;
        }
    }
}