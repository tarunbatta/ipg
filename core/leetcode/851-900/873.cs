// Url:https://leetcode.com/problems/length-of-longest-fibonacci-subsequence

/*
873. Length of Longest Fibonacci Subsequence
Medium

A sequence X_1, X_2, ..., X_n&#xA0;is fibonacci-like if:


	n &gt;= 3
	X_i + X_{i+1} = X_{i+2}&#xA0;for all&#xA0;i + 2 &lt;= n


Given a strictly increasing&#xA0;array&#xA0;A of positive integers forming a sequence, find the length of the longest fibonacci-like subsequence of A.&#xA0; If one does not exist, return 0.

(Recall that a subsequence is derived from another sequence A by&#xA0;deleting any number of&#xA0;elements (including none)&#xA0;from A, without changing the order of the remaining elements.&#xA0; For example, [3, 5, 8] is a subsequence of [3, 4, 5, 6, 7, 8].)

&#xA0;




Example 1:

Input: [1,2,3,4,5,6,7,8]
Output: 5
Explanation:
The longest subsequence that is fibonacci-like: [1,2,3,5,8].


Example 2:

Input: [1,3,7,11,12,14,18]
Output: 3
Explanation:
The longest subsequence that is fibonacci-like:
[1,11,12], [3,11,14] or [7,11,18].


&#xA0;

Note:


	3 &lt;= A.length &lt;= 1000
	1 &lt;= A[0] &lt; A[1] &lt; ... &lt; A[A.length - 1] &lt;= 10^9
	(The time limit has been reduced by 50% for submissions in Java, C, and C++.)
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution873
{
    public class Solution
    {
        public void Init() { }

        public int LenLongestFibSubseq(int[] A) { }
    }
}
