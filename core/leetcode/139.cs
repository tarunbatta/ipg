// Url:https://leetcode.com/problems/word-break

/*
139. Word Break
Medium

Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words.

Note:
The same word in the dictionary may be reused multiple times in the segmentation.
You may assume the dictionary does not contain duplicate words.


Example 1:

Input: s = "leetcode", wordDict = ["leet", "code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code".


Example 2:

Input: s = "applepenapple", wordDict = ["apple", "pen"]
Output: true
Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
             Note that you are allowed to reuse a dictionary word.


Example 3:

Input: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
Output: false
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem139
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine(WordBreak_a("leetcode", new List<string>() { "leet", "code" }));
            Console.WriteLine(WordBreak_a("applepenapple", new List<string>() { "apple", "pen" }));
            Console.WriteLine(WordBreak_a("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" }));

            Console.WriteLine(WordBreak_b("leetcode", new List<string>() { "leet", "code" }));
            Console.WriteLine(WordBreak_b("applepenapple", new List<string>() { "apple", "pen" }));
            Console.WriteLine(WordBreak_b("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" }));
        }

        public bool WordBreak_a(string s, IList<string> wordDict)
        {
            List<bool?> memo = new List<bool?>(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                memo.Add(false);
            }

            return WordBreakHelper(s, wordDict, 0, memo);
        }

        private bool WordBreakHelper(String s, IList<String> wordDict, int start, List<bool?> memo)
        {
            if (start == s.Length)
            {
                return true;
            }

            if (memo[start] != null)
            {
                return (bool)memo[start];
            }

            for (int end = start + 1; end <= s.Length; end++)
            {
                if (wordDict.Contains(s.Substring(start, end)) && WordBreakHelper(s, wordDict, end, memo))
                {
                    memo[start] = true;
                    return (bool)memo[start];
                }
            }

            memo[start] = false;
            return (bool)memo[start];
        }

        public bool WordBreak_b(String s, IList<String> wordDict)
        {
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string str = s.Substring(j, i - j);

                    if (dp[j] && wordDict.Contains(str))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}