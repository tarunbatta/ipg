// Url:https://leetcode.com/problems/diet-plan-performance

/*
1176. Diet Plan Performance
Easy

A dieter consumes&#xA0;calories[i]&#xA0;calories on the i-th day.&#xA0;

Given an integer k, for every consecutive sequence of k days (calories[i], calories[i+1], ..., calories[i+k-1]&#xA0;for all 0 &lt;= i &lt;= n-k), they look at T, the total calories consumed during that sequence of k days (calories[i] + calories[i+1] + ... + calories[i+k-1]):


	If T &lt; lower, they performed poorly on their diet and lose 1 point;&#xA0;
	If T &gt; upper, they performed well on their diet and gain 1 point;
	Otherwise, they performed normally and there is no change in points.


Initially, the dieter has zero points. Return the total number of points the dieter has after dieting for calories.length&#xA0;days.

Note that the total points can be negative.

&#xA0;
Example 1:

Input: calories = [1,2,3,4,5], k = 1, lower = 3, upper = 3
Output: 0
Explanation: Since k = 1, we consider each element of the array separately and compare it to lower and upper.
calories[0] and calories[1] are less than lower so 2 points are lost.
calories[3] and calories[4] are greater than upper so 2 points are gained.


Example 2:

Input: calories = [3,2], k = 2, lower = 0, upper = 1
Output: 1
Explanation: Since k = 2, we consider subarrays of length 2.
calories[0] + calories[1] &gt; upper so 1 point is gained.


Example 3:

Input: calories = [6,5,0,0], k = 2, lower = 1, upper = 5
Output: 0
Explanation:
calories[0] + calories[1] &gt; upper so 1 point is gained.
lower &lt;= calories[1] + calories[2] &lt;= upper so no change in points.
calories[2] + calories[3] &lt; lower so 1 point is lost.


&#xA0;
Constraints:


	1 &lt;= k &lt;= calories.length &lt;= 10^5
	0 &lt;= calories[i] &lt;= 20000
	0 &lt;= lower &lt;= upper
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1176
{
    public class Solution
    {
        public void Init() { }

        public int DietPlanPerformance(int[] calories, int k, int lower, int upper) { }
    }
}
