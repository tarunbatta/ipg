// Url:https://leetcode.com/problems/number-of-submatrices-that-sum-to-target

/*
1074. Number of Submatrices That Sum to Target
Hard

Given a matrix, and a target, return the number of non-empty submatrices that sum to target.

A submatrix x1, y1, x2, y2 is the set of all cells matrix[x][y] with x1 &lt;= x &lt;= x2 and y1 &lt;= y &lt;= y2.

Two submatrices (x1, y1, x2, y2) and (x1&apos;, y1&apos;, x2&apos;, y2&apos;) are different if they have some coordinate&#xA0;that is different: for example, if x1 != x1&apos;.

&#xA0;

Example 1:

Input: matrix = [[0,1,0],[1,1,1],[0,1,0]], target = 0
Output: 4
Explanation: The four 1x1 submatrices that only contain 0.



Example 2:

Input: matrix = [[1,-1],[-1,1]], target = 0
Output: 5
Explanation: The two 1x2 submatrices, plus the two 2x1 submatrices, plus the 2x2 submatrix.



&#xA0;

Note:


	1 &lt;= matrix.length &lt;= 300
	1 &lt;= matrix[0].length &lt;= 300
	-1000 &lt;= matrix[i] &lt;= 1000
	-10^8 &lt;= target &lt;= 10^8
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1074
{
    public class Solution
    {
        public void Init()
        {

        }

        public int NumSubmatrixSumTarget(int[][] matrix, int target) { }
    }
}
