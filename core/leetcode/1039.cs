// Url:https://leetcode.com/problems/minimum-score-triangulation-of-polygon

/*
1039. Minimum Score Triangulation of Polygon
Medium

Given N, consider a convex N-sided polygon with vertices labelled A[0], A[i], ..., A[N-1]&#xA0;in clockwise order.

Suppose you triangulate the polygon into N-2 triangles.&#xA0; For each triangle, the value of that triangle is the product&#xA0;of the labels of the vertices, and the total score of the triangulation is the sum of these values over all N-2 triangles in the triangulation.

Return the smallest possible total score that you can achieve with some triangulation of the polygon.

&#xA0;





Example 1:

Input: [1,2,3]
Output: 6
Explanation: The polygon is already triangulated, and the score of the only triangle is 6.



Example 2:



Input: [3,7,4,5]
Output: 144
Explanation: There are two triangulations, with possible scores: 3*7*5 + 4*5*7 = 245, or 3*4*5 + 3*4*7 = 144.  The minimum score is 144.



Example 3:

Input: [1,3,1,4,1,5]
Output: 13
Explanation: The minimum score triangulation has score 1*1*3 + 1*1*4 + 1*1*5 + 1*1*1 = 13.


&#xA0;

Note:


	3 &lt;= A.length &lt;= 50
	1 &lt;= A[i] &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1039
{
    public class Solution
    {
        public void Init() { }

        public int MinScoreTriangulation(int[] A) { }
    }
}
