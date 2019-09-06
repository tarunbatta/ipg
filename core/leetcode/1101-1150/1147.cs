// Url:https://leetcode.com/problems/longest-chunked-palindrome-decomposition

/*
1147. Longest Chunked Palindrome Decomposition
Hard

Return the largest possible k&#xA0;such that there exists&#xA0;a_1, a_2, ..., a_k&#xA0;such that:


	Each a_i is a non-empty string;
	Their concatenation a_1 + a_2 + ... + a_k is equal to text;
	For all 1 &lt;= i &lt;= k,&#xA0;&#xA0;a_i = a_{k+1 - i}.


&#xA0;
Example 1:

Input: text = &quot;ghiabcdefhelloadamhelloabcdefghi&quot;
Output: 7
Explanation: We can split the string on &quot;(ghi)(abcdef)(hello)(adam)(hello)(abcdef)(ghi)&quot;.


Example 2:

Input: text = &quot;merchant&quot;
Output: 1
Explanation: We can split the string on &quot;(merchant)&quot;.


Example 3:

Input: text = &quot;antaprezatepzapreanta&quot;
Output: 11
Explanation: We can split the string on &quot;(a)(nt)(a)(pre)(za)(tpe)(za)(pre)(a)(nt)(a)&quot;.


Example 4:

Input: text = &quot;aaa&quot;
Output: 3
Explanation: We can split the string on &quot;(a)(a)(a)&quot;.


&#xA0;
Constraints:


	text consists only of lowercase English characters.
	1 &lt;= text.length &lt;= 1000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1147
{
    public class Solution
    {
        public void Init() { }

        public int LongestDecomposition(string text) { }
    }
}
