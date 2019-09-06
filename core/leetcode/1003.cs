// Url:https://leetcode.com/problems/check-if-word-is-valid-after-substitutions

/*
1003. Check If Word Is Valid After Substitutions
Medium

We are given that the string &quot;abc&quot; is valid.

From any valid string V, we may split&#xA0;V into two pieces X and Y such that X + Y (X concatenated with Y) is equal to V.&#xA0; (X or Y may be empty.)&#xA0; Then, X + &quot;abc&quot; + Y is also valid.

If for example S = &quot;abc&quot;, then examples of valid strings are: &quot;abc&quot;, &quot;aabcbc&quot;, &quot;abcabc&quot;, &quot;abcabcababcc&quot;.&#xA0; Examples of invalid&#xA0;strings are: &quot;abccba&quot;, &quot;ab&quot;, &quot;cababc&quot;, &quot;bac&quot;.

Return true if and only if the given string&#xA0;S&#xA0;is valid.

&#xA0;

Example 1:

Input: &quot;aabcbc&quot;
Output: true
Explanation: 
We start with the valid string &quot;abc&quot;.
Then we can insert another &quot;abc&quot; between &quot;a&quot; and &quot;bc&quot;, resulting in &quot;a&quot; + &quot;abc&quot; + &quot;bc&quot; which is &quot;aabcbc&quot;.



Example 2:

Input: &quot;abcabcababcc&quot;
Output: true
Explanation: 
&quot;abcabcabc&quot; is valid after consecutive insertings of &quot;abc&quot;.
Then we can insert &quot;abc&quot; before the last letter, resulting in &quot;abcabcab&quot; + &quot;abc&quot; + &quot;c&quot; which is &quot;abcabcababcc&quot;.



Example 3:

Input: &quot;abccba&quot;
Output: false



Example 4:

Input: &quot;cababc&quot;
Output: false

&#xA0;




Note:


	1 &lt;= S.length &lt;= 20000
	S[i] is &apos;a&apos;, &apos;b&apos;, or &apos;c&apos;





&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1003
{
    public class Solution
    {
        public void Init() { }

        public bool IsValid(string S) { }
    }
}
