// Url: https://leetcode.com/problems/restore-ip-addresses/

/*
93. Restore IP Addresses
Medium

Given a string containing only digits, restore it by returning all possible valid IP address combinations.

Example:

Input: "25525511135"
Output: ["255.255.11.135", "255.255.111.35"]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.Solution93 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        public IList<string> RestoreIpAddresses (string s) {
            List<string> result = new List<string> ();

            for (int i = 1; i < 4 && i < s.Length; i++) {
                string a = s.Substring (0, i);

                if (ValidateIpPart (a)) {
                    for (int j = 1; j < 4 && i + j < s.Length; j++) {
                        string b = s.Substring (i, j);

                        if (ValidateIpPart (b)) {
                            for (int k = 1; k < 4 && i + j + k < s.Length; k++) {
                                string c = s.Substring (i + j, k);
                                string d = s.Substring (i + j + k);

                                if (ValidateIpPart (c) && ValidateIpPart (d)) {
                                    result.Add (string.Concat (a, ".", b, ".", c, ".", d));
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        private bool ValidateIpPart (string str) {
            if (str.Length > 3 || string.IsNullOrEmpty (str))
                return false;

            if (str[0] == '0' && str.Length > 1)
                return false;

            int i = Convert.ToInt32 (str);
            return i >= 0 && i <= 255;
        }
    }
}