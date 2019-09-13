// Url: https://leetcode.com/problems/longest-common-prefix/

/*
14. Longest Common Prefix
Easy

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:
Input: ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: ["dog","racecar","car"]
Output: ""

Explanation: There is no common prefix among the input strings.

Note:
All given inputs are in lowercase letters a-z.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution14 {
    public class Solution {
        public void Init () {
            Console.WriteLine (LongestCommonPrefix (null));
            Console.WriteLine (LongestCommonPrefix (new string[] { "flower", "flow", "flight" }));
            Console.WriteLine (LongestCommonPrefix (new string[] { "dog", "racecar", "car" }));
        }

        public string LongestCommonPrefix (string[] strs) {
            if (strs == null || strs.Length == 0) {
                return string.Empty;
            }

            if (strs.Length == 1) {
                return strs[0];
            }

            String prefix = strs[0];
            
            for (int i = 1; i < strs.Length; i++) {
                while (strs[i].IndexOf (prefix) != 0) {
                    prefix = prefix.Substring (0, prefix.Length - 1);

                    if (string.IsNullOrEmpty (prefix)) {
                        return string.Empty;
                    }
                }
            }

            return prefix;
        }
    }
}