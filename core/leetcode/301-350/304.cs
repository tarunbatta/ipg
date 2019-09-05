// Url:https://leetcode.com/problems/range-sum-query-2d-immutable

/*
304. Range Sum Query 2D - Immutable
Medium

Given a 2D matrix matrix, find the sum of the elements inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).



The above rectangle (with the red border) is defined by (row1, col1) = (2, 1) and (row2, col2) = (4, 3), which contains sum = 8.


Example:
Given matrix = [
  [3, 0, 1, 4, 2],
  [5, 6, 3, 2, 1],
  [1, 2, 0, 1, 5],
  [4, 1, 0, 1, 7],
  [1, 0, 3, 0, 5]
]

sumRegion(2, 1, 4, 3) -&gt; 8
sumRegion(1, 1, 2, 2) -&gt; 11
sumRegion(1, 2, 2, 4) -&gt; 12



Note:

You may assume that the matrix does not change.
There are many calls to sumRegion function.
You may assume that row1 &#x2264; row2 and col1 &#x2264; col2.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution304
{
    public class NumMatrix {​    public NumMatrix(int[][] matrix) { } public int SumRegion(int row1, int col1, int row2, int col2) { } }​/** * Your NumMatrix object will be instantiated and called as such: * NumMatrix obj = new NumMatrix(matrix); * int param_1 = obj.SumRegion(row1,col1,row2,col2); *
}
