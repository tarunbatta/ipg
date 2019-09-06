// Url:https://leetcode.com/problems/custom-sort-string

/*
791. Custom Sort String
Medium

S and T are strings composed of lowercase letters. In S, no letter occurs more than once.

S was sorted in some custom order previously. We want to permute the characters of T so that they match the order that S was sorted. More specifically, if x occurs before y in S, then x should occur before y in the returned string.

Return any permutation of T (as a string) that satisfies this property.

Example :
Input: 
S = &quot;cba&quot;
T = &quot;abcd&quot;
Output: &quot;cbad&quot;
Explanation: 
&quot;a&quot;, &quot;b&quot;, &quot;c&quot; appear in S, so the order of &quot;a&quot;, &quot;b&quot;, &quot;c&quot; should be &quot;c&quot;, &quot;b&quot;, and &quot;a&quot;. 
Since &quot;d&quot; does not appear in S, it can be at any position in T. &quot;dcba&quot;, &quot;cdba&quot;, &quot;cbda&quot; are also valid outputs.


&#xA0;

Note:


	S has length at most 26, and no character is repeated in S.
	T has length at most 200.
	S and T consist of lowercase letters only.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution791
{
    public class Solution
    {
        public void Init() { }

        public string CustomSortString(string S, string T) { }
    }
}
