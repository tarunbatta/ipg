// Url:https://leetcode.com/problems/add-and-search-word-data-structure-design

/*
211. Add and Search Word - Data structure design
Medium

Design a data structure that supports the following two operations:

void addWord(word)
bool search(word)


search(word) can search a literal word or a regular expression string containing only letters a-z or .. A . means it can represent any one letter.

Example:

addWord(&quot;bad&quot;)
addWord(&quot;dad&quot;)
addWord(&quot;mad&quot;)
search(&quot;pad&quot;) -&gt; false
search(&quot;bad&quot;) -&gt; true
search(&quot;.ad&quot;) -&gt; true
search(&quot;b..&quot;) -&gt; true


Note:
You may assume that all words are consist of lowercase letters a-z.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution211
{
    public class WordDictionary {​    /** Initialize your data structure here. */    public WordDictionary() { }        /** Adds a word into the data structure. */    public void AddWord(string word) { }        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */    public bool Search(string word) { } }​/** * Your WordDictionary object will be instantiated and called as such: * WordDictionary obj = new WordDictionary(); * obj.AddWord(word); * bool param_2 = obj.Search(word); *
}
