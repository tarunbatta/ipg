// Url:https://leetcode.com/problems/implement-magic-dictionary

/*
676. Implement Magic Dictionary
Medium

Implement a magic directory with buildDict, and search methods.



For the method buildDict, you&apos;ll be given a list of non-repetitive words to build a dictionary.



For the method search, you&apos;ll be given a word, and judge whether if you modify exactly one character into another character in this word, the modified word is in the dictionary you just built.


Example 1:
Input: buildDict([&quot;hello&quot;, &quot;leetcode&quot;]), Output: Null
Input: search(&quot;hello&quot;), Output: False
Input: search(&quot;hhllo&quot;), Output: True
Input: search(&quot;hell&quot;), Output: False
Input: search(&quot;leetcoded&quot;), Output: False



Note:

You may assume that all the inputs are consist of lowercase letters a-z.
For contest purpose, the test data is rather small by now. You could think about highly efficient algorithm after the contest.
Please remember to RESET your class variables declared in class MagicDictionary, as static/class variables are persisted across multiple test cases. Please see here for more details.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution676
{
    public class MagicDictionary {​    /** Initialize your data structure here. */    public MagicDictionary() { }        /** Build a dictionary through a list of words */    public void BuildDict(string[] dict) { }        /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */    public bool Search(string word) { } }​/** * Your MagicDictionary object will be instantiated and called as such: * MagicDictionary obj = new MagicDictionary(); * obj.BuildDict(dict); * bool param_2 = obj.Search(word); *
}
