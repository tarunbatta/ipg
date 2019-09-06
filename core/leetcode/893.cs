// Url:https://leetcode.com/problems/groups-of-special-equivalent-strings

/*
893. Groups of Special-Equivalent Strings
Easy

You are given an array A of strings.

Two strings S and T are&#xA0;special-equivalent&#xA0;if after any number of moves, S == T.

A move consists of choosing two indices i and j with i % 2 == j % 2, and swapping S[i] with S[j].

Now, a group of special-equivalent strings from A&#xA0;is a&#xA0;non-empty subset S of A&#xA0;such that any string not in S&#xA0;is not special-equivalent with any string in S.

Return the number of groups of special-equivalent strings from A.

&#xA0;





Example 1:

Input: [&quot;a&quot;,&quot;b&quot;,&quot;c&quot;,&quot;a&quot;,&quot;c&quot;,&quot;c&quot;]
Output: 3
Explanation: 3 groups [&quot;a&quot;,&quot;a&quot;], [&quot;b&quot;], [&quot;c&quot;,&quot;c&quot;,&quot;c&quot;]



Example 2:

Input: [&quot;aa&quot;,&quot;bb&quot;,&quot;ab&quot;,&quot;ba&quot;]
Output: 4
Explanation: 4 groups [&quot;aa&quot;], [&quot;bb&quot;], [&quot;ab&quot;], [&quot;ba&quot;]



Example 3:

Input: [&quot;abc&quot;,&quot;acb&quot;,&quot;bac&quot;,&quot;bca&quot;,&quot;cab&quot;,&quot;cba&quot;]
Output: 3
Explanation: 3 groups [&quot;abc&quot;,&quot;cba&quot;], [&quot;acb&quot;,&quot;bca&quot;], [&quot;bac&quot;,&quot;cab&quot;]



Example 4:

Input: [&quot;abcd&quot;,&quot;cdab&quot;,&quot;adcb&quot;,&quot;cbad&quot;]
Output: 1
Explanation: 1 group [&quot;abcd&quot;,&quot;cdab&quot;,&quot;adcb&quot;,&quot;cbad&quot;]


&#xA0;

Note:


	1 &lt;= A.length &lt;= 1000
	1 &lt;= A[i].length &lt;= 20
	All A[i] have the same length.
	All A[i] consist of only lowercase letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution893
{
    public class Solution
    {
        public void Init() { }

        public int NumSpecialEquivGroups(string[] A) { }
    }
}
