// Url:https://leetcode.com/problems/minimum-ascii-delete-sum-for-two-strings

/*
712. Minimum ASCII Delete Sum for Two Strings
Medium

Given two strings s1, s2, find the lowest ASCII sum of deleted characters to make two strings equal.

Example 1:
Input: s1 = &quot;sea&quot;, s2 = &quot;eat&quot;
Output: 231
Explanation: Deleting &quot;s&quot; from &quot;sea&quot; adds the ASCII value of &quot;s&quot; (115) to the sum.
Deleting &quot;t&quot; from &quot;eat&quot; adds 116 to the sum.
At the end, both strings are equal, and 115 + 116 = 231 is the minimum sum possible to achieve this.



Example 2:
Input: s1 = &quot;delete&quot;, s2 = &quot;leet&quot;
Output: 403
Explanation: Deleting &quot;dee&quot; from &quot;delete&quot; to turn the string into &quot;let&quot;,
adds 100[d]+101[e]+101[e] to the sum.  Deleting &quot;e&quot; from &quot;leet&quot; adds 101[e] to the sum.
At the end, both strings are equal to &quot;let&quot;, and the answer is 100+101+101+101 = 403.
If instead we turned both strings into &quot;lee&quot; or &quot;eet&quot;, we would get answers of 433 or 417, which are higher.



Note:
0 &lt; s1.length, s2.length &lt;= 1000.
All elements of each string will have an ASCII value in [97, 122].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution712
{
    public class Solution
    {
        public void Init() { }

        public int MinimumDeleteSum(string s1, string s2) { }
    }
}
