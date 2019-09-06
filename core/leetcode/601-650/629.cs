// Url:https://leetcode.com/problems/k-inverse-pairs-array

/*
629. K Inverse Pairs Array
Hard

Given two integers n and k, find how many different arrays consist of numbers from 1 to n such that there are exactly k inverse pairs.

We define an inverse pair as following: For ith and jth element in the array, if i &lt; j and a[i] &gt; a[j] then it&apos;s an inverse pair; Otherwise, it&apos;s not.

Since the answer may be very large, the answer should be modulo 109 + 7.

Example 1:

Input: n = 3, k = 0
Output: 1
Explanation: 
Only the array [1,2,3] which consists of numbers from 1 to 3 has exactly 0 inverse pair.


&#xA0;

Example 2:

Input: n = 3, k = 1
Output: 2
Explanation: 
The array [1,3,2] and [2,1,3] have exactly 1 inverse pair.


&#xA0;

Note:


	The integer n is in the range [1, 1000] and k is in the range [0, 1000].


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution629
{
    public class Solution
    {
        public void Init() { }

        public int KInversePairs(int n, int k) { }
    }
}