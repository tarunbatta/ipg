// Url:https://leetcode.com/problems/wildcard-matching

/*
44. Wildcard Matching
Hard

Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for &apos;?&apos; and &apos;*&apos;.

&apos;?&apos; Matches any single character.
&apos;*&apos; Matches any sequence of characters (including the empty sequence).


The matching should cover the entire input string (not partial).

Note:


	s&#xA0;could be empty and contains only lowercase letters a-z.
	p could be empty and contains only lowercase letters a-z, and characters like ?&#xA0;or&#xA0;*.


Example 1:

Input:
s = &quot;aa&quot;
p = &quot;a&quot;
Output: false
Explanation: &quot;a&quot; does not match the entire string &quot;aa&quot;.


Example 2:

Input:
s = &quot;aa&quot;
p = &quot;*&quot;
Output: true
Explanation:&#xA0;&apos;*&apos; matches any sequence.


Example 3:

Input:
s = &quot;cb&quot;
p = &quot;?a&quot;
Output: false
Explanation:&#xA0;&apos;?&apos; matches &apos;c&apos;, but the second letter is &apos;a&apos;, which does not match &apos;b&apos;.


Example 4:

Input:
s = &quot;adceb&quot;
p = &quot;*a*b&quot;
Output: true
Explanation:&#xA0;The first &apos;*&apos; matches the empty sequence, while the second &apos;*&apos; matches the substring &quot;dce&quot;.


Example 5:

Input:
s = &quot;acdcb&quot;
p = &quot;a*c?b&quot;
Output: false
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution44
{
    public class Solution
    {
        public void Init() { }

        public bool IsMatch(string s, string p) { }
    }
}
