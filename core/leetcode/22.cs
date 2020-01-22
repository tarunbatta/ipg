// Url:https://leetcode.com/problems/generate-parentheses

/*
22. Generate Parentheses
Medium

Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

For example, given n = 3, a solution set is:
[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem22 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        // Time: O ()
        // Space: O ()
        public IList<string> GenerateParenthesis_a (int n) {
            List<String> ans = new List<string> ();
            backtrack (ans, "", 0, 0, n);
            return ans;
        }

        private void backtrack (List<String> ans, String cur, int open, int close, int max) {
            if (cur.Length == max * 2) {
                ans.Add (cur);
                return;
            }

            if (open < max)
                backtrack (ans, cur + "(", open + 1, close, max);
            if (close < open)
                backtrack (ans, cur + ")", open, close + 1, max);
        }

        public IList<string> GenerateParenthesis_b (int n) {
            var result = new List<string> ();
            generateAll (new char[2 * n], 0, result);
            return result;
        }

        private void generateAll (char[] arr, int pos, List<string> result) {
            if (pos == arr.Length) {
                if (valid (arr)) {
                    result.Add (new string (arr));
                }
            } else {
                arr[pos] = '(';
                generateAll (arr, pos + 1, result);
                arr[pos] = ')';
                generateAll (arr, pos + 1, result);
            }
        }

        private bool valid (char[] current) {
            int count = 0;

            foreach (char c in current) {
                if (c == '(') {
                    count++;
                } else {
                    count--;
                }

                if (count < 0) {
                    return false;
                }
            }

            return (count == 0);
        }
    }
}