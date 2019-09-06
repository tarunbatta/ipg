// Url:https://leetcode.com/problems/maximum-sum-circular-subarray

/*
918. Maximum Sum Circular Subarray
Medium

Given a circular&#xA0;array&#xA0;C of integers represented by&#xA0;A, find the maximum possible sum of a non-empty subarray of C.

Here, a&#xA0;circular&#xA0;array means the end of the array connects to the beginning of the array.&#xA0; (Formally, C[i] = A[i] when 0 &lt;= i &lt; A.length, and C[i+A.length] = C[i]&#xA0;when&#xA0;i &gt;= 0.)

Also, a subarray may only include each element of the fixed buffer A at most once.&#xA0; (Formally, for a subarray C[i], C[i+1], ..., C[j], there does not exist i &lt;= k1, k2 &lt;= j with k1 % A.length&#xA0;= k2 % A.length.)

&#xA0;


Example 1:

Input: [1,-2,3,-2]
Output: 3
Explanation: Subarray [3] has maximum sum 3



Example 2:

Input: [5,-3,5]
Output: 10
Explanation:&#xA0;Subarray [5,5] has maximum sum 5 + 5 = 10



Example 3:

Input: [3,-1,2,-1]
Output: 4
Explanation:&#xA0;Subarray [2,-1,3] has maximum sum 2 + (-1) + 3 = 4



Example 4:

Input: [3,-2,2,-3]
Output: 3
Explanation:&#xA0;Subarray [3] and [3,-2,2] both have maximum sum 3


Example 5:

Input: [-2,-3,-1]
Output: -1
Explanation:&#xA0;Subarray [-1] has maximum sum -1


&#xA0;

Note: 


	-30000 &lt;= A[i] &lt;= 30000
	1 &lt;= A.length &lt;= 30000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution918
{
    public class Solution
    {
        public void Init() { }

        public int MaxSubarraySumCircular(int[] A) { }
    }
}
