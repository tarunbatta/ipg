// Url:https://leetcode.com/problems/palindrome-pairs

/*
336. Palindrome Pairs
Hard

Given a list of unique words, find all pairs of distinct indices (i, j) in the given list, so that the concatenation of the two words, i.e. words[i] + words[j] is a palindrome.

Example 1:


Input: ["abcd","dcba","lls","s","sssll"]
Output: [[0,1],[1,0],[3,2],[2,4]] 
Explanation: The palindromes are ["dcbaabcd","abcddcba","slls","llssssll"]



Example 2:

Input: ["bat","tab","cat"]
Output: [[0,1],[1,0]] 
Explanation: The palindromes are ["battab","tabbat"]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem336
{
    public class Solution
    {
        public void Init()
        {
            PrintPalindromePairs(PalindromePairs_a(new string[] { "bat", "tab", "cat" }));
            PrintPalindromePairs(PalindromePairs_a(new string[] { "abcd", "dcba", "lls", "s", "sssll" }));

            PrintPalindromePairs(PalindromePairs_b(new string[] { "bat", "tab", "cat" }));
            PrintPalindromePairs(PalindromePairs_b(new string[] { "abcd", "dcba", "lls", "s", "sssll" }));
        }

        public IList<IList<int>> PalindromePairs_a(string[] words)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (words != null && words.Length > 1)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (i != j && IsPalindrome(words[i] + words[j]))
                        {
                            IList<int> match = new List<int>();
                            match.Add(i);
                            match.Add(j);
                            result.Add(match);
                        }
                    }
                }
            }

            return result;
        }

        private void PrintPalindromePairs(IList<IList<int>> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(string.Join(",", item));
                }
            }
        }

        private bool IsPalindrome(string word)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(word))
            {
                char[] arr = word.ToCharArray();

                for (int i = 0, j = arr.Length - 1; i < arr.Length / 2 && j >= 0; i++, j--)
                {
                    if (arr[i] != arr[j])
                    {
                        return false;
                    }
                }

                result = true;
            }

            return result;
        }

        public IList<IList<int>> PalindromePairs_b(string[] words)
        {
            IList<IList<int>> result = new List<IList<int>>();
            PalindromePairsTrie trie = new PalindromePairsTrie();

            for (int i = 0; i < words.Length; i++)
            {
                add(trie, words[i], i);
            }

            for (int i = 0; i < words.Length; i++)
            {
                search(trie, words, i, result);
            }

            return result;
        }

        private void add(PalindromePairsTrie root, String word, int pos)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char ch = word[i];

                if (IsPalindrome(word, 0, i))
                {
                    root.palins.Add(pos);
                }

                if (root.nodes[ch - 'a'] == null)
                {
                    root.nodes[ch - 'a'] = new PalindromePairsTrie();
                }

                root = root.nodes[ch - 'a'];
            }

            root.pos = pos;
            root.palins.Add(pos);
        }

        private void search(PalindromePairsTrie root, String[] words, int i, IList<IList<int>> result)
        {
            int len = words[i].Length;

            for (int j = 0; j < len && root != null; j++)
            {
                if (root.pos >= 0 && i != root.pos && IsPalindrome(words[i], j, len - 1))
                {
                    result.Add(new List<int>() { i, root.pos });
                }

                char ch = words[i][j];
                root = root.nodes[ch - 'a'];
            }

            if (root != null && root.palins.Count > 0)
            {
                foreach (var j in root.palins)
                {
                    if (j != i)
                    {
                        result.Add(new List<int>() { i, j });
                    }
                }
            }
        }

        private bool IsPalindrome(string word, int i, int j)
        {
            while (i < j)
            {
                if (word[i++] != word[j--])
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class PalindromePairsTrie
    {
        public int pos;
        public PalindromePairsTrie[] nodes;
        public List<int> palins;

        public PalindromePairsTrie()
        {
            pos = -1;
            nodes = new PalindromePairsTrie[26];
            palins = new List<int>();
        }
    }
}