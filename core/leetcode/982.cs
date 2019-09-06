// Url:https://leetcode.com/problems/triples-with-bitwise-and-equal-to-zero

/*
982. Triples with Bitwise AND Equal To Zero
Hard

Given an array of integers A, find the number of&#xA0;triples of indices (i, j, k)&#xA0;such that:


	0 &lt;= i &lt; A.length
	0 &lt;= j &lt; A.length
	0 &lt;= k &lt; A.length
	A[i]&#xA0;&amp; A[j]&#xA0;&amp; A[k] == 0, where &amp;&#xA0;represents the bitwise-AND operator.


&#xA0;

Example 1:

Input: [2,1,3]
Output: 12
Explanation: We could choose the following i, j, k triples:
(i=0, j=0, k=1) : 2 &amp; 2 &amp; 1
(i=0, j=1, k=0) : 2 &amp; 1 &amp; 2
(i=0, j=1, k=1) : 2 &amp; 1 &amp; 1
(i=0, j=1, k=2) : 2 &amp; 1 &amp; 3
(i=0, j=2, k=1) : 2 &amp; 3 &amp; 1
(i=1, j=0, k=0) : 1 &amp; 2 &amp; 2
(i=1, j=0, k=1) : 1 &amp; 2 &amp; 1
(i=1, j=0, k=2) : 1 &amp; 2 &amp; 3
(i=1, j=1, k=0) : 1 &amp; 1 &amp; 2
(i=1, j=2, k=0) : 1 &amp; 3 &amp; 2
(i=2, j=0, k=1) : 3 &amp; 2 &amp; 1
(i=2, j=1, k=0) : 3 &amp; 1 &amp; 2


&#xA0;

Note:


	1 &lt;= A.length &lt;= 1000
	0 &lt;= A[i] &lt; 2^16
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution982
{
    public class Solution
    {
        public void Init() { }

        public int CountTriplets(int[] A) { }
    }
}
