// Url:https://leetcode.com/problems/most-common-word

/*
819. Most Common Word
Easy

Given a paragraph&#xA0;and a list of banned words, return the most frequent word that is not in the list of banned words.&#xA0; It is guaranteed there is at least one word that isn&apos;t banned, and that the answer is unique.

Words in the list of banned words are given in lowercase, and free of punctuation.&#xA0; Words in the paragraph are not case sensitive.&#xA0; The answer is in lowercase.

&#xA0;

Example:

Input: 
paragraph = &quot;Bob hit a ball, the hit BALL flew far after it was hit.&quot;
banned = [&quot;hit&quot;]
Output: &quot;ball&quot;
Explanation: 
&quot;hit&quot; occurs 3 times, but it is a banned word.
&quot;ball&quot; occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
Note that words in the paragraph are not case sensitive,
that punctuation is ignored (even if adjacent to words, such as &quot;ball,&quot;), 
and that &quot;hit&quot; isn&apos;t the answer even though it occurs more because it is banned.


&#xA0;

Note: 


	1 &lt;= paragraph.length &lt;= 1000.
	0 &lt;= banned.length &lt;= 100.
	1 &lt;= banned[i].length &lt;= 10.
	The answer is unique, and written in lowercase (even if its occurrences in paragraph&#xA0;may have&#xA0;uppercase symbols, and even if it is a proper noun.)
	paragraph only consists of letters, spaces, or the punctuation symbols !?&apos;,;.
	There are no hyphens or hyphenated words.
	Words only consist of letters, never apostrophes or other punctuation symbols.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution819
{
    public class Solution
    {
        public void Init() { }

        public string MostCommonWord(string paragraph, string[] banned) { }
    }
}
