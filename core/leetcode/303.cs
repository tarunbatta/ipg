// Url:https://leetcode.com/problems/range-sum-query-immutable

/*
303. Range Sum Query - Immutable
Easy

Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

Example:
Given nums = [-2, 0, 3, -5, 2, -1]

sumRange(0, 2) -> 1
sumRange(2, 5) -> -1
sumRange(0, 5) -> -3



Note:

You may assume that the array does not change.
There are many calls to sumRange function.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution303 {
    public class Solution {
        public void Init () {
            NumArray obj = new NumArray (null);
            int param_1 = obj.SumRange (0, 0);
        }
    }

    public class NumArray {
        public NumArray (int[] nums) { }

        public int SumRange (int i, int j) {
            return 0;
        }
    }
}