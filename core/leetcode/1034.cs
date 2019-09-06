// Url:https://leetcode.com/problems/coloring-a-border

/*
1034. Coloring A Border
Medium

Given a 2-dimensional&#xA0;grid of integers, each value in the grid represents the color of the grid square at that location.

Two squares belong to the same connected component if and only if they have the same color and are next to each other in any of the 4 directions.

The&#xA0;border of a connected component is&#xA0;all the squares in the connected component that are&#xA0;either 4-directionally adjacent to&#xA0;a square not in the component, or on the boundary of the grid (the first or last row or column).

Given a square at location&#xA0;(r0, c0)&#xA0;in the grid and a color, color the&#xA0;border of the connected component of that square with the given color, and return the final grid.

&#xA0;

Example 1:

Input: grid = [[1,1],[1,2]], r0 = 0, c0 = 0, color = 3
Output: [[3, 3], [3, 2]]



Example 2:

Input: grid = [[1,2,2],[2,3,2]], r0 = 0, c0 = 1, color = 3
Output: [[1, 3, 3], [2, 3, 3]]



Example 3:

Input: grid = [[1,1,1],[1,1,1],[1,1,1]], r0 = 1, c0 = 1, color = 2
Output: [[2, 2, 2], [2, 1, 2], [2, 2, 2]]



&#xA0;

Note:


	1 &lt;= grid.length &lt;= 50
	1 &lt;= grid[0].length &lt;= 50
	1 &lt;= grid[i][j] &lt;= 1000
	0 &lt;= r0 &lt; grid.length
	0 &lt;= c0 &lt; grid[0].length
	1 &lt;= color &lt;= 1000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1034
{
    public class Solution
    {
        public void Init() { }

        public int[][] ColorBorder(int[][] grid, int r0, int c0, int color) { }
    }
}
