// Url:https://leetcode.com/problems/shortest-path-in-binary-matrix

/*
1091. Shortest Path in Binary Matrix
Medium

In an N by N square grid, each cell is either empty (0) or blocked (1).

A&#xA0;clear&#xA0;path from top-left to bottom-right&#xA0;has length k if and only if it is composed of cells C_1, C_2, ..., C_k&#xA0;such that:


	Adjacent cells C_i and C_{i+1} are connected 8-directionally (ie., they are different and&#xA0;share an edge or corner)
	C_1 is at location (0, 0) (ie. has value grid[0][0])
	C_k&#xA0;is at location (N-1, N-1) (ie. has value grid[N-1][N-1])
	If C_i is located at&#xA0;(r, c), then grid[r][c] is empty (ie.&#xA0;grid[r][c] ==&#xA0;0).


Return the length of the shortest such clear path from top-left to bottom-right.&#xA0; If such a path does not exist, return -1.

&#xA0;

Example 1:

Input: [[0,1],[1,0]]


Output: 2




Example 2:

Input: [[0,0,0],[1,1,0],[1,1,0]]


Output: 4



&#xA0;


Note:


	1 &lt;= grid.length == grid[0].length &lt;= 100
	grid[r][c] is 0 or 1
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1091
{
    public class Solution
    {
        public void Init() { }

        public int ShortestPathBinaryMatrix(int[][] grid) { }
    }
}
