// Url:https://leetcode.com/problems/race-car

/*
818. Race Car
Hard

Your car starts at position 0 and speed +1 on an infinite number line.&#xA0; (Your car can go into negative positions.)

Your car drives automatically according to a sequence of instructions A (accelerate) and R (reverse).

When you get an instruction &quot;A&quot;, your car does the following:&#xA0;position += speed, speed *= 2.

When you get an instruction &quot;R&quot;, your car does the following: if your speed is positive then&#xA0;speed = -1&#xA0;, otherwise&#xA0;speed = 1.&#xA0; (Your position stays the same.)

For example, after commands &quot;AAR&quot;, your car goes to positions 0-&gt;1-&gt;3-&gt;3, and your speed goes to 1-&gt;2-&gt;4-&gt;-1.

Now for some target position, say the length of the shortest sequence of instructions to get there.

Example 1:
Input: 
target = 3
Output: 2
Explanation: 
The shortest instruction sequence is &quot;AA&quot;.
Your position goes from 0-&gt;1-&gt;3.


Example 2:
Input: 
target = 6
Output: 5
Explanation: 
The shortest instruction sequence is &quot;AAARA&quot;.
Your position goes from 0-&gt;1-&gt;3-&gt;7-&gt;7-&gt;6.


&#xA0;

Note: 


	1 &lt;= target &lt;= 10000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution818
{
    public class Solution
    {
        public void Init() { }

        public int Racecar(int target) { }
    }
}
