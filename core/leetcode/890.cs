// Url:https://leetcode.com/problems/find-and-replace-pattern

/*
890. Find and Replace Pattern
Medium

You have a list of&#xA0;words and a pattern, and you want to know which words in words matches the pattern.

A word matches the pattern if there exists a permutation of letters p so that after replacing every letter x in the pattern with p(x), we get the desired word.

(Recall that a permutation of letters is a bijection from letters to letters: every letter maps to another letter, and no two letters map to the same letter.)

Return a list of the words in words&#xA0;that match the given pattern.&#xA0;

You may return the answer in any order.

&#xA0;


Example 1:

Input: words = [&quot;abc&quot;,&quot;deq&quot;,&quot;mee&quot;,&quot;aqq&quot;,&quot;dkd&quot;,&quot;ccc&quot;], pattern = &quot;abb&quot;
Output: [&quot;mee&quot;,&quot;aqq&quot;]
Explanation: &quot;mee&quot; matches the pattern because there is a permutation {a -&gt; m, b -&gt; e, ...}. 
&quot;ccc&quot; does not match the pattern because {a -&gt; c, b -&gt; c, ...} is not a permutation,
since a and b map to the same letter.

&#xA0;

Note:


	1 &lt;= words.length &lt;= 50
	1 &lt;= pattern.length = words[i].length&#xA0;&lt;= 20
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution890
{
    public class Solution
    {
        public void Init() { }

        public IList<string> FindAndReplacePattern(string[] words, string pattern) { }
    }
}
