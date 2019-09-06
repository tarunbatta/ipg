// Url:https://leetcode.com/problems/adding-two-negabinary-numbers

/*
1073. Adding Two Negabinary Numbers
Medium

Given two numbers arr1 and arr2 in base -2, return the result of adding them together.

Each number is given in array format:&#xA0; as an array of 0s and 1s, from most significant bit to least significant bit.&#xA0; For example, arr = [1,1,0,1] represents the number (-2)^3&#xA0;+ (-2)^2 + (-2)^0 = -3.&#xA0; A number arr in array format is also guaranteed to have no leading zeros: either&#xA0;arr == [0] or arr[0] == 1.

Return the result of adding arr1 and arr2 in the same format: as an array of 0s and 1s with no leading zeros.

&#xA0;

Example 1:

Input: arr1 = [1,1,1,1,1], arr2 = [1,0,1]
Output: [1,0,0,0,0]
Explanation: arr1 represents 11, arr2 represents 5, the output represents 16.


&#xA0;

Note:


	1 &lt;= arr1.length &lt;= 1000
	1 &lt;= arr2.length &lt;= 1000
	arr1 and arr2 have no leading zeros
	arr1[i] is 0 or 1
	arr2[i] is 0 or 1
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1073
{
    public class Solution
    {
        public void Init() { }

        public int[] AddNegabinary(int[] arr1, int[] arr2) { }
    }
}
