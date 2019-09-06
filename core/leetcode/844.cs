// Url:https://leetcode.com/problems/backspace-string-compare

/*
844. Backspace String Compare
Easy

Given two&#xA0;strings&#xA0;S&#xA0;and T,&#xA0;return if they are equal when both are typed into empty text editors. # means a backspace character.


Example 1:

Input: S = &quot;ab#c&quot;, T = &quot;ad#c&quot;
Output: true
Explanation: Both S and T become &quot;ac&quot;.



Example 2:

Input: S = &quot;ab##&quot;, T = &quot;c#d#&quot;
Output: true
Explanation: Both S and T become &quot;&quot;.



Example 3:

Input: S = &quot;a##c&quot;, T = &quot;#a#c&quot;
Output: true
Explanation: Both S and T become &quot;c&quot;.



Example 4:

Input: S = &quot;a#c&quot;, T = &quot;b&quot;
Output: false
Explanation: S becomes &quot;c&quot; while T becomes &quot;b&quot;.


Note:


	1 &lt;= S.length &lt;= 200
	1 &lt;= T.length &lt;= 200
	S&#xA0;and T only contain&#xA0;lowercase letters and &apos;#&apos; characters.


Follow up:


	Can you solve it in O(N) time and O(1) space?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution844
{
    public class Solution
    {
        public void Init() { }

        public bool BackspaceCompare(string S, string T) { }
    }
}
