// Url:https://leetcode.com/problems/maximum-sum-of-3-non-overlapping-subarrays

/*
689. Maximum Sum of 3 Non-Overlapping Subarrays
Hard

In a given array nums of positive integers, find three non-overlapping subarrays with maximum sum.

Each subarray will be of size k, and we want to maximize the sum of all 3*k entries.

Return the result as a list of indices representing the starting position of each interval (0-indexed). If there are multiple answers, return the lexicographically smallest one.

Example:

Input: [1,2,1,2,6,7,5,1], 2
Output: [0, 3, 5]
Explanation: Subarrays [1, 2], [2, 6], [7, 5] correspond to the starting indices [0, 3, 5].
We could have also taken [2, 1], but an answer of [1, 3, 5] would be lexicographically larger.


&#xA0;

Note:


	nums.length will be between 1 and 20000.
	nums[i] will be between 1 and 65535.
	k will be between 1 and floor(nums.length / 3).


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution689
{
    public class Solution
    {
        public void Init() { }

        public int[] MaxSumOfThreeSubarrays(int[] nums, int k) { }
    }
}
