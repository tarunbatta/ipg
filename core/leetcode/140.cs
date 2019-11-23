// Url: https://leetcode.com/problems/word-break-ii/

/*
140. Word Break II
Hard

Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, add spaces in s to construct a sentence where each word is a valid dictionary word. Return all such possible sentences.

Note:

The same word in the dictionary may be reused multiple times in the segmentation.
You may assume the dictionary does not contain duplicate words.
Example 1:

Input:
s = "catsanddog"
wordDict = ["cat", "cats", "and", "sand", "dog"]
Output:
[
  "cats and dog",
  "cat sand dog"
]
Example 2:

Input:
s = "pineapplepenapple"
wordDict = ["apple", "pen", "applepen", "pine", "pineapple"]
Output:
[
  "pine apple pen apple",
  "pineapple pen apple",
  "pine applepen apple"
]
Explanation: Note that you are allowed to reuse a dictionary word.
Example 3:

Input:
s = "catsandog"
wordDict = ["cats", "dog", "sand", "and", "cat"]
Output:
[]
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreperationGuide.Core.LeetCode.problem140
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine(WordBreak(null, null));
            Console.WriteLine(WordBreak(null, new List<string> { "cats", "and", "sand", "dog" }));
            Console.WriteLine(WordBreak("catsanddog", new List<string> { "cats", "and", "sand", "dog" }));
            Console.WriteLine(WordBreak("pineapplepenapple", new List<string> { "apple", "pen", "applepen", "pine", "pineapple" }));
            Console.WriteLine(WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }));
        }

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            if (string.IsNullOrEmpty(s) || wordDict == null)
            {
                return null;
            }

            if (wordDict.Count == 0)
            {
                return wordDict;
            }

            List<string> result = new List<string>();
            result = DFS(s, wordDict, new Dictionary<string, LinkedList<string>>());

            return result;
        }

        public List<string> DFS(string s, IList<string> wordDict, Dictionary<string, LinkedList<String>> map)
        {
            // Look up cache 
            if (map.ContainsKey(s))
            {
                return map[s].ToList();
            }

            var list = new LinkedList<String>();

            // base case 
            if (s.Length == 0)
            {
                list.AddLast("");
                return list.ToList();
            }

            // go over each word in dictionary
            foreach (string word in wordDict)
            {
                if (s.StartsWith(word))
                {
                    var sublist = DFS(s.Substring(word.Length), wordDict, map);

                    foreach (string sub in sublist)
                    {
                        list.AddLast(word + (string.IsNullOrEmpty(sub) ? "" : " ") + sub);
                    }
                }
            }

            // memoization
            map.Add(s, list);

            return list.ToList();
        }
    }
}