// Url:https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60

/*
1010. Pairs of Songs With Total Durations Divisible by 60
Easy

In a list of songs, the i-th&#xA0;song has a duration of&#xA0;time[i] seconds.&#xA0;

Return the number of pairs of songs for which their total&#xA0;duration in seconds is divisible by 60.&#xA0; Formally, we want the number of&#xA0;indices i &lt; j with (time[i] + time[j]) % 60 == 0.

&#xA0;

Example 1:

Input: [30,20,150,100,40]
Output: 3
Explanation: Three pairs have a total duration divisible by 60:
(time[0] = 30, time[2] = 150): total duration 180
(time[1] = 20, time[3] = 100): total duration 120
(time[1] = 20, time[4] = 40): total duration 60



Example 2:

Input: [60,60,60]
Output: 3
Explanation: All three pairs have a total duration of 120, which is divisible by 60.



&#xA0;

Note:


	1 &lt;= time.length &lt;= 60000
	1 &lt;= time[i] &lt;= 500
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1010
{
    public class Solution
    {
        public void Init() { }

        public int NumPairsDivisibleBy60(int[] time) { }
    }
}
