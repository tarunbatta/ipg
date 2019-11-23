// Url:https://leetcode.com/problems/missing-number

/*
268. Missing Number
Easy

Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

Example 1:

Input: [3,0,1]
Output: 2


Example 2:

Input: [9,6,4,2,3,5,7,0,1]
Output: 8


Note:
Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem268
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine(MissingNumber_a(null));
            Console.WriteLine(MissingNumber_a(new int[] { }));
            Console.WriteLine(MissingNumber_a(new int[] { 3, 0, 1 }));
            Console.WriteLine(MissingNumber_a(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));

            Console.WriteLine(MissingNumber_b(null));
            Console.WriteLine(MissingNumber_b(new int[] { }));
            Console.WriteLine(MissingNumber_b(new int[] { 3, 0, 1 }));
            Console.WriteLine(MissingNumber_b(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
        }

        public int MissingNumber_a(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int result = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            result = (nums.Length * (nums.Length + 1) / 2) - sum;
            return result;
        }

        public int MissingNumber_b(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int result = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= i ^ nums[i];
            }

            return result;
        }
    }
}