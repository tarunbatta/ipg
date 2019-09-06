// Url:https://leetcode.com/problems/satisfiability-of-equality-equations

/*
990. Satisfiability of Equality Equations
Medium

Given an array equations&#xA0;of strings that represent relationships between variables, each string equations[i]&#xA0;has length 4 and takes one of two different forms: &quot;a==b&quot; or &quot;a!=b&quot;.&#xA0; Here, a and b are lowercase letters (not necessarily different) that represent one-letter variable names.

Return true&#xA0;if and only if it is possible to assign integers to variable names&#xA0;so as to satisfy all the given equations.

&#xA0;





Example 1:

Input: [&quot;a==b&quot;,&quot;b!=a&quot;]
Output: false
Explanation: If we assign say, a = 1 and b = 1, then the first equation is satisfied, but not the second.  There is no way to assign the variables to satisfy both equations.



Example 2:

Input: [&quot;b==a&quot;,&quot;a==b&quot;]
Output: true
Explanation: We could assign a = 1 and b = 1 to satisfy both equations.



Example 3:

Input: [&quot;a==b&quot;,&quot;b==c&quot;,&quot;a==c&quot;]
Output: true



Example 4:

Input: [&quot;a==b&quot;,&quot;b!=c&quot;,&quot;c==a&quot;]
Output: false



Example 5:

Input: [&quot;c==c&quot;,&quot;b==d&quot;,&quot;x!=z&quot;]
Output: true


&#xA0;

Note:


	1 &lt;= equations.length &lt;= 500
	equations[i].length == 4
	equations[i][0] and equations[i][3] are lowercase letters
	equations[i][1] is either &apos;=&apos; or &apos;!&apos;
	equations[i][2] is&#xA0;&apos;=&apos;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution990
{
    public class Solution
    {
        public void Init() { }

        public bool EquationsPossible(string[] equations) { }
    }
}
