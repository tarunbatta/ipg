﻿using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Total Hamming Distance
    /// https://leetcode.com/problems/total-hamming-distance/
    ///
    /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
    /// Now your job is to find the total Hamming distance between all pairs of the given numbers.
    ///
    /// Example:
    /// Input: 4, 14, 2
    /// Output: 6
    ///
    /// Explanation: In binary representation, the 4 is 0100, 14 is 1110, and 2 is 0010
    /// (just showing the four bits relevant in this case). So the answer will be:
    /// HammingDistance(4, 14) + HammingDistance(4, 2) + HammingDistance(14, 2) = 2 + 2 + 2 = 6.
    ///
    /// Note:
    /// Elements of the given array are in the range of 0 to 10^9
    /// Length of the array will not exceed 10^4.
    /// </summary>
    public class Question477 {
        public static void Init (string[] args) {
            Console.WriteLine (TotalHammingDistances (null));
            Program.PrintLine ();
            Console.WriteLine (TotalHammingDistances (new int[] { 4, 14, 2 }));
        }

        public static int TotalHammingDistances (int[] nums) {
            int result = 0;

            if (nums != null && nums.Length > 0) {
                for (int i = 0; i < 32; i++) {
                    int bitCount = 0;

                    for (int j = 0; j < nums.Length; j++) {
                        bitCount += (nums[j] >> i) & 1;
                    }

                    result += bitCount * (nums.Length - bitCount);
                }
            }

            return result;
        }
    }
}