// Url:https://leetcode.com/problems/implement-trie-prefix-tree

/*
208. Implement Trie (Prefix Tree)
Medium

Implement a trie with insert, search, and startsWith methods.

Example:

Trie trie = new Trie();

trie.insert(&quot;apple&quot;);
trie.search(&quot;apple&quot;);   // returns true
trie.search(&quot;app&quot;);     // returns false
trie.startsWith(&quot;app&quot;); // returns true
trie.insert(&quot;app&quot;);   
trie.search(&quot;app&quot;);     // returns true


Note:


	You may assume that all inputs are consist of lowercase letters a-z.
	All inputs are guaranteed to be non-empty strings.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution208
{
    public class Trie {​    /** Initialize your data structure here. */    public Trie() { }        /** Inserts a word into the trie. */    public void Insert(string word) { }        /** Returns if the word is in the trie. */    public bool Search(string word) { }        /** Returns if there is any word in the trie that starts with the given prefix. */    public bool StartsWith(string prefix) { } }​/** * Your Trie object will be instantiated and called as such: * Trie obj = new Trie(); * obj.Insert(word); * bool param_2 = obj.Search(word); * bool param_3 = obj.StartsWith(prefix); *
}
