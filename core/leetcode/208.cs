// Url:https://leetcode.com/problems/implement-trie-prefix-tree

/*
208. Implement Trie (Prefix Tree)
Medium

Implement a trie with insert, search, and startsWith methods.

Example:

Trie trie = new Trie();

trie.insert("apple");
trie.search("apple");   // returns true
trie.search("app");     // returns false
trie.startsWith("app"); // returns true
trie.insert("app");   
trie.search("app");     // returns true


Note:


	You may assume that all inputs are consist of lowercase letters a-z.
	All inputs are guaranteed to be non-empty strings.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem208
{
    public class Solution
    {
        public void Init()
        {
            Trie obj = new Trie();
            obj.Insert("apple");
            bool param_2 = obj.Search("apple");
            bool param_3 = obj.StartsWith("apple");
        }
    }

    public class Trie
    {
        // Initialize your data structure here.
        public Trie()
        {

        }

        // Inserts a word into the trie.
        public void Insert(string word)
        {

        }

        // Returns if the word is in the trie.
        public bool Search(string word)
        {
            return false;
        }

        // Returns if there is any word in the trie that starts with the given prefix.
        public bool StartsWith(string prefix)
        {
            return false;
        }
    }
}