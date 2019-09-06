// Url:https://leetcode.com/problems/maximize-sum-of-array-after-k-negations

/*
1005. Maximize Sum Of Array After K Negations
Easy

Given an array A of integers, we must&#xA0;modify the array in the following way: we choose an i&#xA0;and replace&#xA0;A[i] with -A[i], and we repeat this process K times in total.&#xA0; (We may choose the same index i multiple times.)

Return the largest possible sum of the array after modifying it in this way.

&#xA0;

Example 1:

Input: A = [4,2,3], K = 1
Output: 5
Explanation: Choose indices (1,) and A becomes [4,-2,3].



Example 2:

Input: A = [3,-1,0,2], K = 3
Output: 6
Explanation: Choose indices (1, 2, 2) and A becomes [3,1,0,2].



Example 3:

Input: A = [2,-3,-1,5,-4], K = 2
Output: 13
Explanation: Choose indices (1, 4) and A becomes [2,3,-1,5,4].




&#xA0;

Note:


	1 &lt;= A.length &lt;= 10000
	1 &lt;= K &lt;= 10000
	-100 &lt;= A[i] &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1005
{
    public class Solution
    {
        public void Init() { }

        public int LargestSumAfterKNegations(int[] A, int K) { }
    }
}
