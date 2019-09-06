// Url:https://leetcode.com/problems/find-and-replace-in-string

/*
833. Find And Replace in String
Medium

To some string S, we will perform some&#xA0;replacement&#xA0;operations that replace groups of letters with new ones (not necessarily the same size).

Each replacement operation has 3 parameters: a starting index i, a source word&#xA0;x&#xA0;and a target word&#xA0;y.&#xA0; The rule is that if x&#xA0;starts at position i&#xA0;in the original string S, then we will replace that occurrence of&#xA0;x&#xA0;with&#xA0;y.&#xA0; If not, we do nothing.

For example, if we have&#xA0;S = &quot;abcd&quot;&#xA0;and we have some replacement operation&#xA0;i = 2, x = &quot;cd&quot;, y = &quot;ffff&quot;, then because&#xA0;&quot;cd&quot;&#xA0;starts at position 2&#xA0;in the original string S, we will replace it with &quot;ffff&quot;.

Using another example on S = &quot;abcd&quot;, if we have both the replacement operation i = 0, x = &quot;ab&quot;, y = &quot;eee&quot;, as well as another replacement operation&#xA0;i = 2, x = &quot;ec&quot;, y = &quot;ffff&quot;, this second operation does nothing because in the original string&#xA0;S[2] = &apos;c&apos;, which doesn&apos;t match&#xA0;x[0] = &apos;e&apos;.

All these operations occur simultaneously.&#xA0; It&apos;s guaranteed that there won&apos;t be any overlap in replacement: for example,&#xA0;S = &quot;abc&quot;, indexes = [0, 1],&#xA0;sources = [&quot;ab&quot;,&quot;bc&quot;] is not a valid test case.

Example 1:

Input: S = &quot;abcd&quot;, indexes = [0,2], sources = [&quot;a&quot;,&quot;cd&quot;], targets = [&quot;eee&quot;,&quot;ffff&quot;]
Output: &quot;eeebffff&quot;
Explanation: &quot;a&quot; starts at index 0 in S, so it&apos;s replaced by &quot;eee&quot;.
&quot;cd&quot; starts at index 2 in S, so it&apos;s replaced by &quot;ffff&quot;.


Example 2:

Input: S = &quot;abcd&quot;, indexes = [0,2], sources = [&quot;ab&quot;,&quot;ec&quot;], targets = [&quot;eee&quot;,&quot;ffff&quot;]
Output: &quot;eeecd&quot;
Explanation: &quot;ab&quot; starts at index 0 in S, so it&apos;s replaced by &quot;eee&quot;. 
&quot;ec&quot; doesn&apos;t starts at index 2 in the original S, so we do nothing.


Notes:


	0 &lt;=&#xA0;indexes.length =&#xA0;sources.length =&#xA0;targets.length &lt;= 100
	0&#xA0;&lt;&#xA0;indexes[i]&#xA0;&lt; S.length &lt;= 1000
	All characters in given inputs are lowercase letters.


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution833
{
    public class Solution
    {
        public void Init() { }

        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets) { }
    }
}
