// Url:https://leetcode.com/problems/maximum-subarray

/*
53. Maximum Subarray
Easy

Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

Example:

Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.


Follow up:

If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem53
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine(MaxSubArray(null));
            Console.WriteLine(MaxSubArray(new int[] { }));
            Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int n = nums.Length;
            int currentSum = nums[0];
            int maxSum = nums[0];

            for (int i = 1; i < n; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}