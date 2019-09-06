// Url:https://leetcode.com/problems/walking-robot-simulation

/*
874. Walking Robot Simulation
Easy

A robot on an infinite grid starts at point (0, 0) and faces north.&#xA0; The robot can receive one of three possible types of commands:


	-2: turn left 90 degrees
	-1: turn right 90 degrees
	1 &lt;= x &lt;= 9: move forward x units


Some of the grid squares are obstacles.&#xA0;

The i-th obstacle is at grid point (obstacles[i][0], obstacles[i][1])

If the robot would try to move onto them, the robot stays on the previous grid square instead (but still continues following the rest of the route.)

Return the square of the maximum Euclidean distance that the robot will be from the origin.

&#xA0;

Example 1:

Input: commands = [4,-1,3], obstacles = []
Output: 25
Explanation: robot will go to (3, 4)



Example 2:

Input: commands = [4,-1,4,-2,4], obstacles = [[2,4]]
Output: 65
Explanation: robot will be stuck at (1, 4) before turning left and going to (1, 8)



&#xA0;

Note:


	0 &lt;= commands.length &lt;= 10000
	0 &lt;= obstacles.length &lt;= 10000
	-30000 &lt;= obstacle[i][0] &lt;= 30000
	-30000 &lt;= obstacle[i][1] &lt;= 30000
	The answer is guaranteed to be less than 2 ^ 31.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution874
{
    public class Solution
    {
        public void Init() { }

        public int RobotSim(int[] commands, int[][] obstacles) { }
    }
}
