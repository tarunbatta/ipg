// Url: https://leetcode.com/problems/longest-substring-without-repeating-characters/

/*
3. Longest Substring Without Repeating Characters
Medium

Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

using System;
using System.Collections;

namespace InterviewPreperationGuide.Core.LeetCode.Solution3 {
    public class Solution {
        public void Init () {
            Console.WriteLine (LengthOfLongestSubstring_a (null));
            Console.WriteLine (LengthOfLongestSubstring_a ("abcabcbb"));
            Console.WriteLine (LengthOfLongestSubstring_a ("bbbbb"));
            Console.WriteLine (LengthOfLongestSubstring_a ("pwwkew"));
            Console.WriteLine (LengthOfLongestSubstring_a ("dvdf"));

            Console.WriteLine (LengthOfLongestSubstring_b (null));
            Console.WriteLine (LengthOfLongestSubstring_b ("abcabcbb"));
            Console.WriteLine (LengthOfLongestSubstring_b ("bbbbb"));
            Console.WriteLine (LengthOfLongestSubstring_b ("pwwkew"));
            Console.WriteLine (LengthOfLongestSubstring_b ("dvdf"));

            Console.WriteLine (LengthOfLongestSubstring_c (null));
            Console.WriteLine (LengthOfLongestSubstring_c ("abcabcbb"));
            Console.WriteLine (LengthOfLongestSubstring_c ("bbbbb"));
            Console.WriteLine (LengthOfLongestSubstring_c ("pwwkew"));
            Console.WriteLine (LengthOfLongestSubstring_c ("dvdf"));
        }

        public int LengthOfLongestSubstring_a (String s) {
            int result = 0;

            if (string.IsNullOrEmpty (s)) {
                return result;
            }

            Hashtable hash = new Hashtable ();

            for (int j = 0, i = 0; j < s.Length; j++) {
                if (hash.ContainsKey (s[j])) {
                    i = Math.Max (i, (int) hash[s[j]] + 1);
                    hash[s[j]] = j;
                } else {
                    hash.Add (s[j], j);
                }

                result = Math.Max (result, j - i + 1);
            }

            return result;
        }

        public int LengthOfLongestSubstring_b (String s) {
            int result = 0;

            if (string.IsNullOrEmpty (s)) {
                return result;
            }

            Hashtable hash = new Hashtable ();
            int i = 0, j = 0;

            while (i < s.Length && j < s.Length) {
                if (!hash.ContainsKey (s[j])) {
                    hash.Add (s[j++], j);
                    result = Math.Max (result, j - i);
                } else {
                    hash.Remove (s[i++]);
                }
            }

            return result;
        }

        public int LengthOfLongestSubstring_c (string s) {
            int result = 0;

            if (string.IsNullOrEmpty (s)) {
                return result;
            }

            int max = 0;
            Hashtable hash = new Hashtable ();

            for (int i = 0; i < s.Length; i++) {
                if (!hash.ContainsKey (s[i])) {
                    hash.Add (s[i], i);
                    max++;
                } else {
                    i = (int) hash[s[i]];
                    hash = new Hashtable ();
                    result = max > result ? max : result;
                    max = 0;
                }
            }

            result = max > result ? max : result;

            return result;
        }
    }
}