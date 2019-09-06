// Url:https://leetcode.com/problems/maximum-nesting-depth-of-two-valid-parentheses-strings

/*
1111. Maximum Nesting Depth of Two Valid Parentheses Strings
Medium

A string is a valid parentheses string&#xA0;(denoted VPS) if and only if it consists of &quot;(&quot; and &quot;)&quot; characters only, and:


	It is the empty string, or
	It can be written as&#xA0;AB&#xA0;(A&#xA0;concatenated with&#xA0;B), where&#xA0;A&#xA0;and&#xA0;B&#xA0;are VPS&apos;s, or
	It can be written as&#xA0;(A), where&#xA0;A&#xA0;is a VPS.


We can&#xA0;similarly define the nesting depth depth(S) of any VPS S as follows:


	depth(&quot;&quot;) = 0
	depth(A + B) = max(depth(A), depth(B)), where A and B are VPS&apos;s
	depth(&quot;(&quot; + A + &quot;)&quot;) = 1 + depth(A), where A is a VPS.


For example,&#xA0; &quot;&quot;,&#xA0;&quot;()()&quot;, and&#xA0;&quot;()(()())&quot;&#xA0;are VPS&apos;s (with nesting depths 0, 1, and 2), and &quot;)(&quot; and &quot;(()&quot; are not VPS&apos;s.

&#xA0;

Given a VPS seq, split it into two disjoint subsequences A and B, such that&#xA0;A and B are VPS&apos;s (and&#xA0;A.length + B.length = seq.length).

Now choose any such A and B such that&#xA0;max(depth(A), depth(B)) is the minimum possible value.

Return an answer array (of length seq.length) that encodes such a&#xA0;choice of A and B:&#xA0; answer[i] = 0 if seq[i] is part of A, else answer[i] = 1.&#xA0; Note that even though multiple answers may exist, you may return any of them.

&#xA0;
Example 1:

Input: seq = &quot;(()())&quot;
Output: [0,1,1,1,1,0]


Example 2:

Input: seq = &quot;()(())()&quot;
Output: [0,0,0,1,1,0,1,1]


&#xA0;
Constraints:


	1 &lt;= seq.size &lt;= 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1111
{
    public class Solution
    {
        public void Init() { }

        public int[] MaxDepthAfterSplit(string seq) { }
    }
}
