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

namespace InterviewPreperationGuide.Core.LeetCode.problem53 {
    public class Solution {
        public void Init () {
            Console.WriteLine (MaxSubArray_a (null));
            Console.WriteLine (MaxSubArray_a (new int[] { }));
            Console.WriteLine (MaxSubArray_a (new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            Console.WriteLine (MaxSubArray_b (null));
            Console.WriteLine (MaxSubArray_b (new int[] { }));
            Console.WriteLine (MaxSubArray_b (new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        public int MaxSubArray_a (int[] nums) {
            if (nums == null || nums.Length == 0) {
                return 0;
            }

            int max = Int32.MinValue;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (sum < 0) {
                    sum = nums[i];
                } else {
                    sum += nums[i];
                }

                if (sum > max)
                    max = sum;
            }

            return max;
        }

        public int MaxSubArray_b (int[] nums) {
            if (nums == null || nums.Length == 0) {
                return 0;
            }

            int n = nums.Length;
            int[] dp = new int[n];
            dp[0] = nums[0];
            int max = dp[0];

            for (int i = 1; i < n; i++) {
                dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = Math.Max (max, dp[i]);
            }

            return max;
        }
    }
}