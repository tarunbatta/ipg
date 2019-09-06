// Url:https://leetcode.com/problems/uncrossed-lines

/*
1035. Uncrossed Lines
Medium

We write the integers of A and B&#xA0;(in the order they are given) on two separate horizontal lines.

Now, we may draw connecting lines: a straight line connecting two numbers A[i] and B[j]&#xA0;such that:


	A[i] == B[j];
	The line we draw does not intersect any other connecting (non-horizontal) line.


Note that a connecting lines cannot intersect even at the endpoints:&#xA0;each number can only belong to one connecting line.

Return the maximum number of connecting lines we can draw in this way.

&#xA0;

Example 1:

Input: A = [1,4,2], B = [1,2,4]
Output: 2
Explanation: We can draw 2 uncrossed lines as in the diagram.
We cannot draw 3 uncrossed lines, because the line from A[1]=4 to B[2]=4 will intersect the line from A[2]=2 to B[1]=2.



Example 2:

Input: A = [2,5,1,2,5], B = [10,5,2,1,5,2]
Output: 3



Example 3:

Input: A = [1,3,7,1,7,5], B = [1,9,2,5,1]
Output: 2

&#xA0;



Note:


	1 &lt;= A.length &lt;= 500
	1 &lt;= B.length &lt;= 500
	1 &lt;= A[i], B[i] &lt;= 2000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1035
{
    public class Solution
    {
        public void Init() { }

        public int MaxUncrossedLines(int[] A, int[] B) { }
    }
}
