using System.Linq;
// Url:https://leetcode.com/problems/license-key-formatting

/*
482. License Key Formatting
Easy

You are given a license key represented as a string S which consists only alphanumeric character and dashes. The string is separated into N+1 groups by N dashes.

Given a number K, we would want to reformat the strings such that each group contains exactly K characters, except for the first group which could be shorter than K, but still must contain at least one character. Furthermore, there must be a dash inserted between two groups and all lowercase letters should be converted to uppercase.

Given a non-empty string S and a number K, format the string according to the rules described above.

Example 1:
Input: S = "5F3Z-2e-9-w", K = 4

Output: "5F3Z-2E9W"

Explanation: The string S has been split into two parts, each part has 4 characters.
Note that the two extra dashes are not needed and can be removed.




Example 2:
Input: S = "2-5g-3-J", K = 2

Output: "2-5G-3J"

Explanation: The string S has been split into three parts, each part has 2 characters except the first part as it could be shorter as mentioned above.



Note:

The length of string S will not exceed 12,000, and K is a positive integer.
String S consists only of alphanumerical characters (a-z and/or A-Z and/or 0-9) and dashes(-).
String S is non-empty.
*/

using System;
using System.Text;

namespace InterviewPreperationGuide.Core.LeetCode.problem482 {
    public class Solution {
        public void Init () {
            Console.WriteLine (LicenseKeyFormatting (null, 0));
            Console.WriteLine (LicenseKeyFormatting ("5F3Z-2e-9-w", 4));
            Console.WriteLine (LicenseKeyFormatting ("2-5g-3-J", 2));
        }

        // Time: O (n)
        // Space: O (n)
        public string LicenseKeyFormatting (string S, int K) {
            if (string.IsNullOrEmpty (S) || K == 0) {
                return S;
            }

            StringBuilder sb = new StringBuilder ();

            for (int i = S.Length - 1; i >= 0; i--) {
                if (S[i] != '-') {
                    if (sb.Length % (K + 1) == K) {
                        sb.Append ('-');
                    }
                    sb.Append (S[i]);
                }
            }

            char[] arr = sb.ToString ().ToCharArray ();
            Array.Reverse (arr);

            return new string (arr).ToUpper ();
        }
    }
}