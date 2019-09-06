// Url:https://leetcode.com/problems/verifying-an-alien-dictionary

/*
953. Verifying an Alien Dictionary
Easy

In an alien language, surprisingly they also use english lowercase letters, but possibly&#xA0;in a different order. The&#xA0;order of the alphabet&#xA0;is some permutation&#xA0;of lowercase letters.

Given a sequence of words&#xA0;written in the alien language,&#xA0;and the order of the alphabet,&#xA0;return true if and only if the given words&#xA0;are sorted lexicographicaly in this alien language.

&#xA0;


Example 1:

Input: words = [&quot;hello&quot;,&quot;leetcode&quot;], order = &quot;hlabcdefgijkmnopqrstuvwxyz&quot;
Output: true
Explanation: As &apos;h&apos; comes before &apos;l&apos; in this language, then the sequence is sorted.



Example 2:

Input: words = [&quot;word&quot;,&quot;world&quot;,&quot;row&quot;], order = &quot;worldabcefghijkmnpqstuvxyz&quot;
Output: false
Explanation: As &apos;d&apos; comes after &apos;l&apos; in this language, then words[0] &gt; words[1], hence the sequence is unsorted.



Example 3:

Input: words = [&quot;apple&quot;,&quot;app&quot;], order = &quot;abcdefghijklmnopqrstuvwxyz&quot;
Output: false
Explanation: The first three characters &quot;app&quot; match, and the second string is shorter (in size.) According to lexicographical rules &quot;apple&quot; &gt; &quot;app&quot;, because &apos;l&apos; &gt; &apos;&#x2205;&apos;, where &apos;&#x2205;&apos; is defined as the blank character which is less than any other character (More info).


&#xA0;

Note:


	1 &lt;= words.length &lt;= 100
	1 &lt;= words[i].length &lt;= 20
	order.length == 26
	All characters in words[i] and order are english lowercase letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution953
{
    public class Solution
    {
        public void Init() { }

        public bool IsAlienSorted(string[] words, string order) { }
    }
}
