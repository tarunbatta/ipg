// Url:https://leetcode.com/problems/search-a-2d-matrix-ii

/*
240. Search a 2D Matrix II
Medium

Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:


	Integers in each row are sorted in ascending from left to right.
	Integers in each column are sorted in ascending from top to bottom.


Example:

Consider the following matrix:

[
  [1,   4,  7, 11, 15],
  [2,   5,  8, 12, 19],
  [3,   6,  9, 16, 22],
  [10, 13, 14, 17, 24],
  [18, 21, 23, 26, 30]
]


Given target = 5, return true.

Given target = 20, return false.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution240 {
    public class Solution {
        public void Init () {
            int[, ] matrix_a = new int[, ] { { 1, 4, 7, 11, 15 }, { 2, 5, 8, 12, 19 }, { 3, 6, 9, 16, 22 }, { 10, 13, 14, 17, 24 }, { 18, 21, 23, 26, 30 }
            };

            Console.WriteLine (SearchMatrix (null, 5));
            Console.WriteLine (SearchMatrix (matrix_a, 5));
            Console.WriteLine (SearchMatrix (matrix_a, 20));

            int[, ] matrix_b = new int[, ] { { 1, 3, 5, 7, 9 }, { 2, 4, 6, 8, 10 }, { 11, 13, 15, 17, 19 }, { 12, 14, 16, 18, 20 }, { 21, 22, 23, 24, 25 }
            };

            Console.WriteLine (SearchMatrix (matrix_b, 13));
        }

        public bool SearchMatrix (int[, ] matrix, int target) {
            if (matrix != null) {
                int rows = matrix.GetLength (0);
                int cols = matrix.GetLength (1);

                int row = 0;
                int col = cols - 1;

                while (row < rows && col >= 0) {
                    if (matrix[row, col] == target) {
                        return true;
                    }

                    if (matrix[row, col] > target) {
                        col--;
                    } else {
                        row++;
                    }
                }
            }

            return false;
        }
    }
}