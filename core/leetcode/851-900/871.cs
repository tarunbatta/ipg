// Url:https://leetcode.com/problems/minimum-number-of-refueling-stops

/*
871. Minimum Number of Refueling Stops
Hard

A car travels from a starting position to a destination which is target miles east of the starting position.

Along the way, there are gas stations.&#xA0; Each station[i]&#xA0;represents a gas station that is station[i][0] miles east of the starting position, and has station[i][1] liters of gas.

The car starts with an infinite tank of gas, which initially has&#xA0;startFuel&#xA0;liters of fuel in it.&#xA0; It uses 1 liter of gas per 1 mile that it drives.

When the car&#xA0;reaches a gas station, it may stop and refuel, transferring all the gas from the station into the car.

What is the least number of refueling stops the car must make in order to reach its destination?&#xA0; If it cannot reach the destination, return -1.

Note that if the car reaches a gas station with 0 fuel left, the car can still refuel there.&#xA0; If the car reaches the destination with 0 fuel left, it is still considered to have arrived.

&#xA0;


Example 1:

Input: target = 1, startFuel = 1, stations = []
Output: 0
Explanation: We can reach the target without refueling.



Example 2:

Input: target = 100, startFuel = 1, stations = [[10,100]]
Output: -1
Explanation: We can&apos;t reach the target (or even the first gas station).



Example 3:

Input: target = 100, startFuel = 10, stations = [[10,60],[20,30],[30,30],[60,40]]
Output: 2
Explanation: 
We start with 10 liters of fuel.
We drive to position 10, expending 10 liters of fuel.  We refuel from 0 liters to 60 liters of gas.
Then, we drive from position 10 to position 60 (expending 50 liters of fuel),
and refuel from 10 liters to 50 liters of gas.  We then drive to and reach the target.
We made 2 refueling stops along the way, so we return 2.


&#xA0;

Note:


	1 &lt;= target, startFuel, stations[i][1] &lt;= 10^9
	0 &lt;= stations.length &lt;= 500
	0 &lt; stations[0][0] &lt; stations[1][0] &lt; ... &lt; stations[stations.length-1][0] &lt; target
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution871
{
    public class Solution
    {
        public int MinRefuelStops(int target, int startFuel, int[][] stations) { }
    }
