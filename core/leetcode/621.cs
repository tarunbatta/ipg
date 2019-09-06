// Url:https://leetcode.com/problems/task-scheduler

/*
621. Task Scheduler
Medium

Given a char array representing tasks CPU need to do. It contains capital letters A to Z where different letters represent different tasks. Tasks could be done without original order. Each task could be done in one interval. For each interval, CPU could finish one task or just be idle.

However, there is a non-negative cooling interval n that means between two same tasks, there must be at least n intervals that CPU are doing different tasks or just be idle.

You need to return the least number of intervals the CPU will take to finish all the given tasks.

&#xA0;

Example:

Input: tasks = [&quot;A&quot;,&quot;A&quot;,&quot;A&quot;,&quot;B&quot;,&quot;B&quot;,&quot;B&quot;], n = 2
Output: 8
Explanation: A -&gt; B -&gt; idle -&gt; A -&gt; B -&gt; idle -&gt; A -&gt; B.


&#xA0;

Note:


	The number of tasks is in the range [1, 10000].
	The integer n is in the range [0, 100].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution621
{
    public class Solution
    {
        public void Init() { }

        public int LeastInterval(char[] tasks, int n) { }
    }
}
