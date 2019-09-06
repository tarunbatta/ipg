// Url:https://leetcode.com/problems/max-increase-to-keep-city-skyline

/*
807. Max Increase to Keep City Skyline
Medium

In a 2 dimensional array grid, each value grid[i][j] represents the height of a building located there. We are allowed to increase the height of any number of buildings, by any amount (the amounts&#xA0;can be different for different buildings). Height&#xA0;0 is considered to be a&#xA0;building&#xA0;as well.&#xA0;

At the end, the &quot;skyline&quot; when viewed from all four directions&#xA0;of the grid, i.e.&#xA0;top, bottom, left, and right,&#xA0;must be the same as the&#xA0;skyline of the original grid. A city&apos;s skyline is the outer contour of the rectangles formed by all the buildings when viewed from a distance. See&#xA0;the following example.

What is the maximum total sum that the height of the buildings can be increased?

Example:
Input: grid = [[3,0,8,4],[2,4,5,7],[9,2,6,3],[0,3,1,0]]
Output: 35
Explanation: 
The grid is:
[ [3, 0, 8, 4], 
  [2, 4, 5, 7],
  [9, 2, 6, 3],
  [0, 3, 1, 0] ]

The skyline viewed from top or bottom is: [9, 4, 8, 7]
The skyline viewed from left or right is: [8, 7, 9, 3]

The grid after increasing the height of buildings without affecting skylines is:

gridNew = [ [8, 4, 8, 7],
            [7, 4, 7, 7],
            [9, 4, 8, 7],
            [3, 3, 3, 3] ]



Notes: 


	1 &lt; grid.length = grid[0].length &lt;= 50.
	All heights grid[i][j] are in the range [0, 100].
	All buildings in grid[i][j] occupy the entire grid cell: that is, they are a 1 x 1 x grid[i][j] rectangular prism.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution807
{
    public class Solution
    {
        public void Init() { }

        public int MaxIncreaseKeepingSkyline(int[][] grid) { }
    }
}
