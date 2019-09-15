// Url: https://leetcode.com/problems/roman-to-integer/

/*
13. Roman to Integer
Easy

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

Example 1:

Input: "III"
Output: 3
Example 2:

Input: "IV"
Output: 4
Example 3:

Input: "IX"
Output: 9
Example 4:

Input: "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 5:

Input: "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem13 {
    public class Solution {
        public void Init () {
            Console.WriteLine (RomanToInt (null));
            Console.WriteLine (RomanToInt ("IX"));
            Console.WriteLine (RomanToInt ("VI"));
            Console.WriteLine (RomanToInt ("MDCLIX"));
            Console.WriteLine (RomanToInt ("MDCIL"));
        }

        public static int RomanToInt (string s) {
            int result = 0;

            if (!string.IsNullOrEmpty (s)) {
                Dictionary<char, int> dict = new Dictionary<char, int> ();
                dict.Add ('I', 1);
                dict.Add ('V', 5);
                dict.Add ('X', 10);
                dict.Add ('L', 50);
                dict.Add ('C', 100);
                dict.Add ('D', 500);
                dict.Add ('M', 1000);

                for (int i = 0; i < s.Length; i++) {
                    if (!dict.ContainsKey (s[i])) {
                        return result;
                    }
                }

                result = dict[s[s.Length - 1]];

                for (int i = s.Length - 2; i >= 0; i--) {
                    if (dict[s[i + 1]] > dict[s[i]]) {
                        result -= dict[s[i]];
                    } else {
                        result += dict[s[i]];
                    }
                }
            }

            return result;
        }
    }
}