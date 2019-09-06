// Url:https://leetcode.com/problems/short-encoding-of-words

/*
820. Short Encoding of Words
Medium

Given a list of words, we may encode it by writing a reference string S and a list of indexes A.

For example, if the list of words is [&quot;time&quot;, &quot;me&quot;, &quot;bell&quot;], we can write it as S = &quot;time#bell#&quot;&#xA0;and indexes = [0, 2, 5].

Then for each index, we will recover the word by reading from the reference string from that index until we reach a &quot;#&quot; character.

What is the length of the shortest reference string S possible that encodes the given words?

Example:

Input: words = [&quot;time&quot;, &quot;me&quot;, &quot;bell&quot;]
Output: 10
Explanation: S = &quot;time#bell#&quot; and indexes = [0, 2, 5].


&#xA0;

Note:


	1 &lt;= words.length&#xA0;&lt;= 2000.
	1 &lt;=&#xA0;words[i].length&#xA0;&lt;= 7.
	Each word&#xA0;has only&#xA0;lowercase letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution820
{
    public class Solution
    {
        public void Init() { }

        public int MinimumLengthEncoding(string[] words) { }
    }
}
