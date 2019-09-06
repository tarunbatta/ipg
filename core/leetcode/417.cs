// Url:https://leetcode.com/problems/pacific-atlantic-water-flow

/*
417. Pacific Atlantic Water Flow
Medium

Given an m x n matrix of non-negative integers representing the height of each unit cell in a continent, the &quot;Pacific ocean&quot; touches the left and top edges of the matrix and the &quot;Atlantic ocean&quot; touches the right and bottom edges.

Water can only flow in four directions (up, down, left, or right) from a cell to another one with height equal or lower.

Find the list of grid coordinates where water can flow to both the Pacific and Atlantic ocean.

Note:


	The order of returned grid coordinates does not matter.
	Both m and n are less than 150.


&#xA0;

Example:

Given the following 5x5 matrix:

  Pacific ~   ~   ~   ~   ~ 
       ~  1   2   2   3  (5) *
       ~  3   2   3  (4) (4) *
       ~  2   4  (5)  3   1  *
       ~ (6) (7)  1   4   5  *
       ~ (5)  1   1   2   4  *
          *   *   *   *   * Atlantic

Return:

[[0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]] (positions with parentheses in above matrix).


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution417
{
    public class Solution
    {
        public void Init() { }

        public IList<IList<int>> PacificAtlantic(int[][] matrix) { }
    }
}
