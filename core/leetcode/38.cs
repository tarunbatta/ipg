using System.Linq;
// Url: https://leetcode.com/problems/count-and-say/

/*
38. Count and Say
Easy

The count-and-say sequence is the sequence of integers with the first five terms as following:

1.     1
2.     11
3.     21
4.     1211
5.     111221
1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.

Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence.

Note: Each term of the sequence of integers will be represented as a string.

Example 1:
Input: 1
Output: "1"

Example 2:
Input: 4
Output: "1211"
*/

using System;
using System.Text;

namespace InterviewPreperationGuide.Core.LeetCode.problem38 {
    public class Solution {
        public void Init () {
            Console.WriteLine (CountAndSay (0));
            Console.WriteLine (CountAndSay (1));
            Console.WriteLine (CountAndSay (4));
        }

        public string CountAndSay (int n) {
            if (n <= 0 || n > 30) {
                return null;
            }

            string result = "1";

            for (int i = 1; i < n; i++) {
                result = countIdx (result);
            }

            return result;
        }

        public String countIdx (String s) {
            StringBuilder sb = new StringBuilder ();
            char c = s[0];
            int count = 1;

            for (int i = 1; i < s.Length; i++) {
                if (s[i] == c) {
                    count++;
                } else {
                    sb.Append (count);
                    sb.Append (c);
                    c = s[i];
                    count = 1;
                }
            }

            sb.Append (count);
            sb.Append (c);

            return sb.ToString ();
        }
    }
}