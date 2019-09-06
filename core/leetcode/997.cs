// Url:https://leetcode.com/problems/find-the-town-judge

/*
997. Find the Town Judge
Easy

In a town, there are N people labelled from&#xA0;1 to N.&#xA0; There is a rumor that one of these people is secretly the town judge.

If the&#xA0;town judge exists, then:


	The town judge trusts nobody.
	Everybody (except for the town judge) trusts the town judge.
	There is exactly one person that satisfies properties 1 and 2.


You are given trust, an array of pairs trust[i] = [a, b] representing that the person labelled a trusts the person labelled b.

If the town judge exists and can be identified, return the label of the town judge.&#xA0; Otherwise, return -1.

&#xA0;

Example 1:

Input: N = 2, trust = [[1,2]]
Output: 2



Example 2:

Input: N = 3, trust = [[1,3],[2,3]]
Output: 3



Example 3:

Input: N = 3, trust = [[1,3],[2,3],[3,1]]
Output: -1



Example 4:

Input: N = 3, trust = [[1,2],[2,3]]
Output: -1



Example 5:

Input: N = 4, trust = [[1,3],[1,4],[2,3],[2,4],[4,3]]
Output: 3

&#xA0;





Note:


	1 &lt;= N &lt;= 1000
	trust.length &lt;= 10000
	trust[i] are all different
	trust[i][0] != trust[i][1]
	1 &lt;= trust[i][0], trust[i][1] &lt;= N
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution997
{
    public class Solution
    {
        public void Init() { }

        public int FindJudge(int N, int[][] trust) { }
    }
}
