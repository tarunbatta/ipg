// Url: https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/

/*
1239. Maximum Length of a Concatenated String with Unique Characters
Medium

Given an array of strings arr. String s is a concatenation of a sub-sequence of arr which have unique characters.

Return the maximum possible length of s.

 

Example 1:

Input: arr = ["un","iq","ue"]
Output: 4
Explanation: All possible concatenations are "","un","iq","ue","uniq" and "ique".
Maximum length is 4.
Example 2:

Input: arr = ["cha","r","act","ers"]
Output: 6
Explanation: Possible solutions are "chaers" and "acters".
Example 3:

Input: arr = ["abcdefghijklmnopqrstuvwxyz"]
Output: 26
 

Constraints:

1 <= arr.length <= 16
1 <= arr[i].length <= 26
arr[i] contains only lower case English letters.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreperationGuide.Core.LeetCode.problem1239 {
    public class Solution {
        public void Init () {

        }

        // Time: O (n^2)
        // Space: O (n^2)
        public int MaxLength (IList<string> arr) {
            var result = 0;
            dfs (arr, ref result, 0, "");
            return result;
        }

        private static void dfs (IList<string> array, ref int maxLength, int index, string path) {
            if (!isUnique (path)) {
                return;
            }

            var current = path.Length;
            maxLength = current > maxLength ? current : maxLength;

            for (int i = index; i < array.Count; i++) {
                dfs (array, ref maxLength, i + 1, path + array[i]);
            }
        }

        private static bool isUnique (string path) {
            var hashSet = new HashSet<char> (path);
            return path.Length == hashSet.Count ();
        }
    }
}