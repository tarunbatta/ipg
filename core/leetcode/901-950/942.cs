// Url:https://leetcode.com/problems/di-string-match

/*
942. DI String Match
Easy

Given a string S that only contains &quot;I&quot; (increase) or &quot;D&quot; (decrease), let N = S.length.

Return any permutation A of [0, 1, ..., N] such that for all i = 0,&#xA0;..., N-1:


	If S[i] == &quot;I&quot;, then A[i] &lt; A[i+1]
	If S[i] == &quot;D&quot;, then A[i] &gt; A[i+1]


&#xA0;

Example 1:

Input: &quot;IDID&quot;
Output: [0,4,1,3,2]



Example 2:

Input: &quot;III&quot;
Output: [0,1,2,3]



Example 3:

Input: &quot;DDI&quot;
Output: [3,2,0,1]



&#xA0;

Note:


	1 &lt;= S.length &lt;= 10000
	S only contains characters &quot;I&quot; or &quot;D&quot;.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution942
{
    public class Solution
    {
        public void Init() { }

        public int[] DiStringMatch(string S) { }
    }
}
