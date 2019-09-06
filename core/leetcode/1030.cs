// Url:https://leetcode.com/problems/matrix-cells-in-distance-order

/*
1030. Matrix Cells in Distance Order
Easy

We are given a matrix with R rows and C columns has cells with integer coordinates&#xA0;(r, c), where 0 &lt;= r &lt; R and 0 &lt;= c &lt; C.

Additionally, we are given a cell in that matrix with coordinates&#xA0;(r0, c0).

Return the coordinates of&#xA0;all cells in the matrix, sorted by their distance from (r0, c0)&#xA0;from smallest distance to largest distance.&#xA0; Here,&#xA0;the distance between two cells (r1, c1) and (r2, c2) is the Manhattan distance,&#xA0;|r1 - r2| + |c1 - c2|.&#xA0; (You may return the answer in any order that satisfies this condition.)

&#xA0;


Example 1:

Input: R = 1, C = 2, r0 = 0, c0 = 0
Output: [[0,0],[0,1]]
Explanation: The distances from (r0, c0) to other cells are: [0,1]



Example 2:

Input: R = 2, C = 2, r0 = 0, c0 = 1
Output: [[0,1],[0,0],[1,1],[1,0]]
Explanation: The distances from (r0, c0) to other cells are: [0,1,1,2]
The answer [[0,1],[1,1],[0,0],[1,0]] would also be accepted as correct.



Example 3:

Input: R = 2, C = 3, r0 = 1, c0 = 2
Output: [[1,2],[0,2],[1,1],[0,1],[1,0],[0,0]]
Explanation: The distances from (r0, c0) to other cells are: [0,1,1,2,2,3]
There are other answers that would also be accepted as correct, such as [[1,2],[1,1],[0,2],[1,0],[0,1],[0,0]].


&#xA0;

Note:


	1 &lt;= R &lt;= 100
	1 &lt;= C &lt;= 100
	0 &lt;= r0 &lt; R
	0 &lt;= c0 &lt; C
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1030
{
    public class Solution
    {
        public void Init() { }

        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0) { }
    }
}
