// Url:https://leetcode.com/problems/range-sum-query-mutable

/*
307. Range Sum Query - Mutable
Medium

Given an integer array nums, find the sum of the elements between indices i and j (i &#x2264; j), inclusive.

The update(i, val) function modifies nums by updating the element at index i to val.

Example:

Given nums = [1, 3, 5]

sumRange(0, 2) -&gt; 9
update(1, 2)
sumRange(0, 2) -&gt; 8


Note:


	The array is only modifiable by the update function.
	You may assume the number of calls to update and sumRange function is distributed evenly.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution307
{
    public class NumArray {​    public NumArray(int[] nums) { } public void Update(int i, int val) { } public int SumRange(int i, int j) { } }​/** * Your NumArray object will be instantiated and called as such: * NumArray obj = new NumArray(nums); * obj.Update(i,val); * int param_2 = obj.SumRange(i,j); *
}
