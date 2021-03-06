// Url:https://leetcode.com/problems/maximal-rectangle

/*
85. Maximal Rectangle
Hard

Given a 2D binary matrix filled with 0's and 1's, find the largest rectangle containing only 1's and return its area.

Example:

Input:
[
  ['1','0','1','0','0'],
  ['1','0','1','1','1'],
  ['1','1','1','1','1'],
  ['1','0','0','1','0']
]
Output: 6
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem85 {
    public class Solution {
        public void Init () {
            Console.WriteLine (MaximalRectangle (null));
            Console.WriteLine (MaximalRectangle (new char[][] {
                new char[] { '1', '0', '1', '0', '0' },
                    new char[] { '1', '0', '1', '1', '1' },
                    new char[] { '1', '1', '1', '1', '1' },
                    new char[] { '1', '0', '0', '1', '0' }
            }));
        }

        public int MaximalRectangle (char[][] matrix) {
            return 0;
        }
    }
}