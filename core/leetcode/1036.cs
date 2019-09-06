// Url:https://leetcode.com/problems/escape-a-large-maze

/*
1036. Escape a Large Maze
Hard

In a 1 million by 1 million grid, the coordinates of each grid square are (x, y) with 0 &lt;= x, y &lt; 10^6.

We start at the source square and want to reach the target square.&#xA0; Each move, we can walk to a 4-directionally adjacent square in the grid that isn&apos;t in the given list of blocked squares.

Return true if and only if it is possible to reach the target square through a sequence of moves.

&#xA0;

Example 1:

Input: blocked = [[0,1],[1,0]], source = [0,0], target = [0,2]
Output: false
Explanation: 
The target square is inaccessible starting from the source square, because we can&apos;t walk outside the grid.


Example 2:

Input: blocked = [], source = [0,0], target = [999999,999999]
Output: true
Explanation: 
Because there are no blocked cells, it&apos;s possible to reach the target square.


&#xA0;

Note:


	0 &lt;= blocked.length &lt;= 200
	blocked[i].length == 2
	0 &lt;= blocked[i][j] &lt; 10^6
	source.length == target.length == 2
	0 &lt;= source[i][j], target[i][j] &lt; 10^6
	source != target
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1036
{
    public class Solution
    {
        public void Init() { }

        public bool IsEscapePossible(int[][] blocked, int[] source, int[] target) { }
    }
}
