// Url:https://leetcode.com/problems/valid-permutations-for-di-sequence

/*
903. Valid Permutations for DI Sequence
Hard

We are given S, a length n string of characters from the set {&apos;D&apos;, &apos;I&apos;}. (These letters stand for &quot;decreasing&quot; and &quot;increasing&quot;.)

A&#xA0;valid permutation&#xA0;is a permutation P[0], P[1], ..., P[n] of integers&#xA0;{0, 1, ..., n}, such that for all i:


	If S[i] == &apos;D&apos;, then P[i] &gt; P[i+1], and;
	If S[i] == &apos;I&apos;, then P[i] &lt; P[i+1].


How many valid permutations are there?&#xA0; Since the answer may be large, return your answer modulo 10^9 + 7.

&#xA0;

Example 1:

Input: &quot;DID&quot;
Output: 5
Explanation: 
The 5 valid permutations of (0, 1, 2, 3) are:
(1, 0, 3, 2)
(2, 0, 3, 1)
(2, 1, 3, 0)
(3, 0, 2, 1)
(3, 1, 2, 0)


&#xA0;

Note:


	1 &lt;= S.length &lt;= 200
	S consists only of characters from the set {&apos;D&apos;, &apos;I&apos;}.



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution903
{
    public class Solution
    {
        public void Init() { }

        public int NumPermsDISequence(string S) { }
    }
}
