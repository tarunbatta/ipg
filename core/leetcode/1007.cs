// Url:https://leetcode.com/problems/minimum-domino-rotations-for-equal-row

/*
1007. Minimum Domino Rotations For Equal Row
Medium

In a row of dominoes, A[i] and B[i] represent the top and bottom halves of the i-th domino.&#xA0; (A domino is a tile with two numbers from 1 to 6 - one on each half of the tile.)

We may rotate the i-th domino, so that A[i] and B[i] swap values.

Return the minimum number of rotations so that all the values in A are the same, or all the values in B&#xA0;are the same.

If it cannot be done, return -1.

&#xA0;

Example 1:



Input: A = [2,1,2,4,2,2], B = [5,2,6,2,3,2]
Output: 2
Explanation: 
The first figure represents the dominoes as given by A and B: before we do any rotations.
If we rotate the second and fourth dominoes, we can make every value in the top row equal to 2, as indicated by the second figure.


Example 2:

Input: A = [3,5,1,2,3], B = [3,6,3,3,4]
Output: -1
Explanation: 
In this case, it is not possible to rotate the dominoes to make one row of values equal.


&#xA0;

Note:


	1 &lt;= A[i], B[i] &lt;= 6
	2 &lt;= A.length == B.length &lt;= 20000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1007
{
    public class Solution
    {
        public void Init() { }

        public int MinDominoRotations(int[] A, int[] B) { }
    }
}
