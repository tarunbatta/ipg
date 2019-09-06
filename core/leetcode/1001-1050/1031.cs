// Url:https://leetcode.com/problems/maximum-sum-of-two-non-overlapping-subarrays

/*
1031. Maximum Sum of Two Non-Overlapping Subarrays
Medium

Given an array A of non-negative integers, return the maximum sum of elements in two non-overlapping (contiguous) subarrays, which have lengths&#xA0;L and M.&#xA0; (For clarification, the L-length subarray could occur before or after the M-length subarray.)

Formally,&#xA0;return the largest V for which&#xA0;V = (A[i] + A[i+1] + ... + A[i+L-1]) + (A[j] + A[j+1] + ... + A[j+M-1]) and either:


	0 &lt;= i &lt; i + L - 1 &lt; j &lt; j + M - 1 &lt; A.length, or
	0 &lt;= j &lt; j + M - 1 &lt; i &lt; i + L - 1 &lt; A.length.


&#xA0;





Example 1:

Input: A = [0,6,5,2,2,5,1,9,4], L = 1, M = 2
Output: 20
Explanation: One choice of subarrays is [9] with length 1, and [6,5] with length 2.



Example 2:

Input: A = [3,8,1,3,2,1,8,9,0], L = 3, M = 2
Output: 29
Explanation: One choice of subarrays is [3,8,1] with length 3, and [8,9] with length 2.



Example 3:

Input: A = [2,1,5,6,0,9,5,0,3,8], L = 4, M = 3
Output: 31
Explanation: One choice of subarrays is [5,6,0,9] with length 4, and [3,8] with length 3.


&#xA0;

Note:


	L &gt;= 1
	M &gt;= 1
	L + M &lt;= A.length &lt;= 1000
	0 &lt;= A[i] &lt;= 1000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1031
{
    public class Solution
    {
        public void Init() { }

        public int MaxSumTwoNoOverlap(int[] A, int L, int M) { }
    }
}
