// Url:https://leetcode.com/problems/minimum-falling-path-sum

/*
931. Minimum Falling Path Sum
Medium

Given a square array of integers A, we want the minimum sum of a falling path through A.

A falling path starts at any element in the first row, and chooses one element from each row.&#xA0; The next row&apos;s choice must be in a column that is different from the previous row&apos;s column by at most one.

&#xA0;

Example 1:

Input: [[1,2,3],[4,5,6],[7,8,9]]
Output: 12
Explanation: 
The possible falling paths are:



	[1,4,7], [1,4,8], [1,5,7], [1,5,8], [1,5,9]
	[2,4,7], [2,4,8], [2,5,7], [2,5,8], [2,5,9], [2,6,8], [2,6,9]
	[3,5,7], [3,5,8], [3,5,9], [3,6,8], [3,6,9]


The falling path with the smallest sum is [1,4,7], so the answer is 12.

&#xA0;

Note:


	1 &lt;= A.length == A[0].length &lt;= 100
	-100 &lt;= A[i][j] &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution931
{
    public class Solution
    {
        public void Init() { }

        public int MinFallingPathSum(int[][] A) { }
    }
}
