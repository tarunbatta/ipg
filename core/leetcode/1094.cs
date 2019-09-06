// Url:https://leetcode.com/problems/car-pooling

/*
1094. Car Pooling
Medium

You are driving a vehicle that&#xA0;has capacity empty seats initially available for passengers.&#xA0; The vehicle only drives east (ie. it cannot turn around and drive west.)

Given a list of trips, trip[i] = [num_passengers, start_location, end_location]&#xA0;contains information about the i-th trip: the number of passengers that must be picked up, and the locations to pick them up and drop them off.&#xA0; The locations are given as the number of kilometers&#xA0;due east from your vehicle&apos;s initial location.

Return true if and only if&#xA0;it is possible to pick up and drop off all passengers for all the given trips.&#xA0;

&#xA0;

Example 1:

Input: trips = [[2,1,5],[3,3,7]], capacity = 4
Output: false



Example 2:

Input: trips = [[2,1,5],[3,3,7]], capacity = 5
Output: true



Example 3:

Input: trips = [[2,1,5],[3,5,7]], capacity = 3
Output: true



Example 4:

Input: trips = [[3,2,7],[3,7,9],[8,3,9]], capacity = 11
Output: true








&#xA0;




&#xA0;
Constraints:


	trips.length &lt;= 1000
	trips[i].length == 3
	1 &lt;= trips[i][0] &lt;= 100
	0 &lt;= trips[i][1] &lt; trips[i][2] &lt;= 1000
	1 &lt;=&#xA0;capacity &lt;= 100000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1094
{
    public class Solution
    {
        public void Init() { }

        public bool CarPooling(int[][] trips, int capacity) { }
    }
}
