// Url:https://leetcode.com/problems/can-make-palindrome-from-substring

/*
1177. Can Make Palindrome from Substring
Medium

Given a string s, we make queries on substrings of s.

For each query queries[i] = [left, right, k], we may rearrange&#xA0;the substring s[left], ..., s[right], and then choose up to k of them to replace with any lowercase English letter.&#xA0;

If the substring&#xA0;is possible to be a&#xA0;palindrome string after the operations above, the result of the query is true.&#xA0;Otherwise, the result&#xA0;is false.

Return an array answer[], where answer[i] is the result of the i-th query queries[i].

Note that: Each letter is counted individually for replacement so&#xA0;if for example&#xA0;s[left..right] = &quot;aaa&quot;, and k = 2, we can only replace two of the letters.&#xA0; (Also, note that the initial string s&#xA0;is never modified by any query.)

&#xA0;
Example :

Input: s = &quot;abcda&quot;, queries = [[3,3,0],[1,2,0],[0,3,1],[0,3,2],[0,4,1]]
Output: [true,false,false,true,true]
Explanation:
queries[0] : substring = &quot;d&quot;, is palidrome.
queries[1] :&#xA0;substring = &quot;bc&quot;, is not palidrome.
queries[2] :&#xA0;substring = &quot;abcd&quot;, is not palidrome after replacing only 1 character.
queries[3] :&#xA0;substring = &quot;abcd&quot;, could be changed to &quot;abba&quot; which is palidrome. Also this can be changed to &quot;baab&quot; first rearrange it &quot;bacd&quot; then replace &quot;cd&quot; with &quot;ab&quot;.
queries[4] :&#xA0;substring = &quot;abcda&quot;,&#xA0;could be changed to &quot;abcba&quot; which is palidrome.


&#xA0;
Constraints:


	1 &lt;= s.length,&#xA0;queries.length&#xA0;&lt;= 10^5
	0 &lt;= queries[i][0] &lt;= queries[i][1] &lt;&#xA0;s.length
	0 &lt;= queries[i][2] &lt;= s.length
	s only contains lowercase English letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1177
{
    public class Solution
    {
        public void Init() { }

        public IList<bool> CanMakePaliQueries(string s, int[][] queries) { }
    }
}
