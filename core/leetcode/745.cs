// Url:https://leetcode.com/problems/prefix-and-suffix-search

/*
745. Prefix and Suffix Search
Hard

Given many words, words[i] has weight i.

Design a class WordFilter that supports one function, WordFilter.f(String prefix, String suffix). It will return the word with given prefix and suffix with maximum weight. If no word exists, return -1.

Examples:

Input:
WordFilter([&quot;apple&quot;])
WordFilter.f(&quot;a&quot;, &quot;e&quot;) // returns 0
WordFilter.f(&quot;b&quot;, &quot;&quot;) // returns -1


&#xA0;

Note:


	words has length in range [1, 15000].
	For each test case, up to words.length queries WordFilter.f may be made.
	words[i] has length in range [1, 10].
	prefix, suffix have lengths in range [0, 10].
	words[i] and prefix, suffix queries consist of lowercase letters only.


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution745
{
    public class WordFilter {​    public WordFilter(string[] words) { } public int F(string prefix, string suffix) { } }​/** * Your WordFilter object will be instantiated and called as such: * WordFilter obj = new WordFilter(words); * int param_1 = obj.F(prefix,suffix); *
}
