// Url:https://leetcode.com/problems/minimum-number-of-k-consecutive-bit-flips

/*
995. Minimum Number of K Consecutive Bit Flips
Hard

In an array A containing only 0s and 1s, a K-bit flip&#xA0;consists of choosing a (contiguous) subarray of length K and simultaneously changing every 0 in the subarray to 1, and every 1 in the subarray to 0.

Return the minimum number of K-bit flips required so that there is no 0 in the array.&#xA0; If it is not possible, return -1.

&#xA0;

Example 1:

Input: A = [0,1,0], K = 1
Output: 2
Explanation: Flip A[0], then flip A[2].



Example 2:

Input: A = [1,1,0], K = 2
Output: -1
Explanation:&#xA0;No matter how we flip subarrays of size 2, we can&apos;t make the array become [1,1,1].



Example 3:

Input: A = [0,0,0,1,0,1,1,0], K = 3
Output: 3
Explanation:
Flip A[0],A[1],A[2]:&#xA0;A becomes [1,1,1,1,0,1,1,0]
Flip A[4],A[5],A[6]:&#xA0;A becomes [1,1,1,1,1,0,0,0]
Flip A[5],A[6],A[7]:&#xA0;A becomes [1,1,1,1,1,1,1,1]


&#xA0;



Note:


	1 &lt;= A.length &lt;=&#xA0;30000
	1 &lt;= K &lt;= A.length
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution995
{
    public class Solution
    {
        public void Init() { }

        public int MinKBitFlips(int[] A, int K) { }
    }
}
