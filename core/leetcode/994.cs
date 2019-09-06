// Url:https://leetcode.com/problems/rotting-oranges

/*
994. Rotting Oranges
Easy

In a given grid, each cell can have one of three&#xA0;values:


	the value 0 representing an empty cell;
	the value 1 representing a fresh orange;
	the value 2 representing a rotten orange.


Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange.&#xA0; If this is impossible, return -1 instead.

&#xA0;


Example 1:



Input: [[2,1,1],[1,1,0],[0,1,1]]
Output: 4



Example 2:

Input: [[2,1,1],[0,1,1],[1,0,1]]
Output: -1
Explanation:  The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.



Example 3:

Input: [[0,2]]
Output: 0
Explanation:  Since there are already no fresh oranges at minute 0, the answer is just 0.


&#xA0;

Note:


	1 &lt;= grid.length &lt;= 10
	1 &lt;= grid[0].length &lt;= 10
	grid[i][j] is only 0, 1, or 2.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution994
{
    public class Solution
    {
        public void Init() { }

        public int OrangesRotting(int[][] grid) { }
    }
}
