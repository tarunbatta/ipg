// Url:https://leetcode.com/problems/score-after-flipping-matrix

/*
861. Score After Flipping Matrix
Medium

We have a two dimensional matrix&#xA0;A where each value is 0 or 1.

A move consists of choosing any row or column, and toggling each value in that row or column: changing all 0s to 1s, and all 1s to 0s.

After making any number of moves, every row of this matrix is interpreted as a binary number, and the score of the matrix is the sum of these numbers.

Return the highest possible&#xA0;score.

&#xA0;





Example 1:

Input: [[0,0,1,1],[1,0,1,0],[1,1,0,0]]
Output: 39
Explanation:
Toggled to [[1,1,1,1],[1,0,0,1],[1,1,1,1]].
0b1111 + 0b1001 + 0b1111 = 15 + 9 + 15 = 39

&#xA0;

Note:


	1 &lt;= A.length &lt;= 20
	1 &lt;= A[0].length &lt;= 20
	A[i][j]&#xA0;is 0 or 1.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution861
{
    public class Solution
    {
        public void Init() { }

        public int MatrixScore(int[][] A) { }
    }
}