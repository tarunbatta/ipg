// Url: https://leetcode.com/problems/longest-palindromic-substring/

/*
5. Longest Palindromic Substring
Medium

Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.

Example 2:

Input: "cbbd"
Output: "bb"
*/

using System;
using System.Text;

namespace InterviewPreperationGuide.Core.LeetCode.problem5 {
    public class Solution {
        public void Init () {
            Console.WriteLine (LongestPalindrome (null));
            Console.WriteLine (LongestPalindrome (""));
            Console.WriteLine (LongestPalindrome ("a"));
            Console.WriteLine (LongestPalindrome ("babad"));
            Console.WriteLine (LongestPalindrome ("cbbd"));
            Console.WriteLine (LongestPalindrome ("babcbaabcbaccba"));
        }

        public string LongestPalindrome (string s) {
            if (String.IsNullOrEmpty (s))
                return string.Empty;

            string pal = s.Substring (0, 1);
            int max = 1;

            for (int i = 0; i < s.Length; ++i) {
                int j = 0;

                // Even-length palindromes with s[i] in the middle
                while (i - j >= 0 && i + j + 1 < s.Length && s[i - j] == s[i + j + 1]) {
                    if (2 * j + 2 > max) {
                        max = 2 * j + 2;
                        pal = s.Substring (i - j, max);
                    }

                    ++j;
                }

                j = 0;
                // Odd-length palindromes with s[i] in the middle
                while (i - j - 1 >= 0 && i + j + 1 < s.Length && s[i - j - 1] == s[i + j + 1]) {
                    if (2 * j + 3 > max) {
                        max = 2 * j + 3;
                        pal = s.Substring (i - j - 1, max);
                    }

                    ++j;
                }
            }

            return pal;
        }

        public string LongestPalindrome_Manacher2 (string s) {
            if (s.Length == 0) {
                return "";
            }

            string T = preProcess (s);
            int n = T.Length;
            int[] P = new int[n];
            int C = 0, R = 0;

            for (int i = 1; i < n - 1; i++) {
                int i_mirror = 2 * C - i; // equals to i' = C - (i-C)

                P[i] = (R > i) ? Math.Min (R - i, P[i_mirror]) : 0;

                // Attempt to expand palindrome centered at i
                while (T[i + 1 + P[i]] == T[i - 1 - P[i]])
                    P[i]++;

                // If palindrome centered at i expand past R,
                // adjust center based on expanded palindrome.
                if (i + P[i] > R) {
                    C = i;
                    R = i + P[i];
                }
            }

            // Find the maximum element in P.
            int maxLen = 0;
            int centerIndex = 0;
            for (int i = 1; i < n - 1; i++) {
                if (P[i] > maxLen) {
                    maxLen = P[i];
                    centerIndex = i;
                }
            }

            return s.Substring ((centerIndex - 1 - maxLen) / 2, maxLen);
        }

        private string preProcess (string s) {
            StringBuilder sb = new StringBuilder (s.Length * 2 + 3);
            sb.Append ('^');

            foreach (char c in s) {
                sb.Append ('#');
                sb.Append (c);
            }

            sb.Append ("#$");

            return sb.ToString ();
        }
    }
}