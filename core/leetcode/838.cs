// Url:https://leetcode.com/problems/push-dominoes

/*
838. Push Dominoes
Medium

There are&#xA0;N dominoes in a line, and we place each domino vertically upright.

In the beginning, we simultaneously push&#xA0;some of the dominoes either to the left or to the right.



After each second, each domino that is falling to the left pushes the adjacent domino on the left.

Similarly, the dominoes falling to the right push their adjacent dominoes standing on the right.

When a vertical domino has dominoes falling on it from both sides, it stays still due to the balance of the forces.

For the purposes of this question, we will consider that a falling domino&#xA0;expends no additional force to a falling or already fallen domino.

Given a string &quot;S&quot; representing the initial state.&#xA0;S[i] = &apos;L&apos;, if the i-th domino has been pushed to the left; S[i] = &apos;R&apos;, if the i-th domino has been pushed to the right; S[i] = &apos;.&apos;,&#xA0;if the i-th domino has not been pushed.

Return a string representing the final state.&#xA0;

Example 1:

Input: &quot;.L.R...LR..L..&quot;
Output: &quot;LL.RR.LLRRLL..&quot;


Example 2:

Input: &quot;RR.L&quot;
Output: &quot;RR.L&quot;
Explanation: The first domino expends no additional force on the second domino.


Note:


	0 &lt;= N&#xA0;&lt;= 10^5
	String&#xA0;dominoes contains only&#xA0;&apos;L&apos;, &apos;R&apos; and &apos;.&apos;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution838
{
    public class Solution
    {
        public void Init() { }

        public string PushDominoes(string dominoes) { }
    }
}
