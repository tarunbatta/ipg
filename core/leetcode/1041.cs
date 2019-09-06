// Url:https://leetcode.com/problems/robot-bounded-in-circle

/*
1041. Robot Bounded In Circle
Medium

On an infinite plane, a&#xA0;robot initially stands at (0, 0) and faces north.&#xA0;&#xA0;The robot can receive one of three instructions:


	&quot;G&quot;: go straight 1 unit;
	&quot;L&quot;: turn 90 degrees to the left;
	&quot;R&quot;: turn 90 degress to the right.


The robot performs the instructions given in order, and repeats them forever.

Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.

&#xA0;

Example 1:

Input: &quot;GGLLGG&quot;
Output: true
Explanation: 
The robot moves from (0,0) to (0,2), turns 180 degrees, and then returns to (0,0).
When repeating these instructions, the robot remains in the circle of radius 2 centered at the origin.


Example 2:

Input: &quot;GG&quot;
Output: false
Explanation: 
The robot moves north indefinitely.


Example 3:

Input: &quot;GL&quot;
Output: true
Explanation: 
The robot moves from (0, 0) -&gt; (0, 1) -&gt; (-1, 1) -&gt; (-1, 0) -&gt; (0, 0) -&gt; ...


&#xA0;

Note:


	1 &lt;= instructions.length &lt;= 100
	instructions[i] is in {&apos;G&apos;, &apos;L&apos;, &apos;R&apos;}
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1041
{
    public class Solution
    {
        public void Init() { }

        public bool IsRobotBounded(string instructions) { }
    }
}
