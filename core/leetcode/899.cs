// Url:https://leetcode.com/problems/orderly-queue

/*
899. Orderly Queue
Hard

A string S of lowercase letters is given.&#xA0; Then, we may make any number of moves.

In each move, we&#xA0;choose one&#xA0;of the first K letters (starting from the left), remove it,&#xA0;and place it at the end of the string.

Return the lexicographically smallest string we could have after any number of moves.

&#xA0;


Example 1:

Input: S = &quot;cba&quot;, K = 1
Output: &quot;acb&quot;
Explanation: 
In the first move, we move the 1st character (&quot;c&quot;) to the end, obtaining the string &quot;bac&quot;.
In the second move, we move the 1st character (&quot;b&quot;) to the end, obtaining the final result &quot;acb&quot;.



Example 2:

Input: S = &quot;baaca&quot;, K = 3
Output: &quot;aaabc&quot;
Explanation: 
In the first move, we move the 1st character (&quot;b&quot;) to the end, obtaining the string &quot;aacab&quot;.
In the second move, we move the 3rd character (&quot;c&quot;) to the end, obtaining the final result &quot;aaabc&quot;.


&#xA0;

Note:


	1 &lt;= K &lt;= S.length&#xA0;&lt;= 1000
	S&#xA0;consists of lowercase letters only.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution899
{
    public class Solution
    {
        public void Init() { }

        public string OrderlyQueue(string S, int K) { }
    }
}
