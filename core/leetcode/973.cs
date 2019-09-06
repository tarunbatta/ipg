// Url:https://leetcode.com/problems/k-closest-points-to-origin

/*
973. K Closest Points to Origin
Medium

We have a list of points&#xA0;on the plane.&#xA0; Find the K closest points to the origin (0, 0).

(Here, the distance between two points on a plane is the Euclidean distance.)

You may return the answer in any order.&#xA0; The&#xA0;answer is guaranteed to be unique (except for the order that it is in.)

&#xA0;


Example 1:

Input: points = [[1,3],[-2,2]], K = 1
Output: [[-2,2]]
Explanation: 
The distance between (1, 3) and the origin is sqrt(10).
The distance between (-2, 2) and the origin is sqrt(8).
Since sqrt(8) &lt; sqrt(10), (-2, 2) is closer to the origin.
We only want the closest K = 1 points from the origin, so the answer is just [[-2,2]].



Example 2:

Input: points = [[3,3],[5,-1],[-2,4]], K = 2
Output: [[3,3],[-2,4]]
(The answer [[-2,4],[3,3]] would also be accepted.)


&#xA0;

Note:


	1 &lt;= K &lt;= points.length &lt;= 10000
	-10000 &lt; points[i][0] &lt; 10000
	-10000 &lt; points[i][1] &lt; 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution973
{
    public class Solution
    {
        public void Init() { }

        public int[][] KClosest(int[][] points, int K) { }
    }
}
