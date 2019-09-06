// Url:https://leetcode.com/problems/exclusive-time-of-functions

/*
636. Exclusive Time of Functions
Medium

On a single threaded CPU, we execute some functions.&#xA0; Each function has a unique id between 0 and N-1.

We store logs in timestamp order that describe when a function is entered or exited.

Each log is a string with this format: &quot;{function_id}:{&quot;start&quot; | &quot;end&quot;}:{timestamp}&quot;.&#xA0; For example, &quot;0:start:3&quot;&#xA0;means the function with id 0 started at the beginning of timestamp 3.&#xA0; &quot;1:end:2&quot; means the function with id 1 ended at the end of timestamp 2.

A function&apos;s exclusive time&#xA0;is the number of units of time spent in this function.&#xA0; Note that this does not include any recursive&#xA0;calls to child functions.

The CPU is single threaded which means that only one function is being executed at a given time unit.

Return the exclusive time of each function, sorted by their function id.

&#xA0;

Example 1:



Input:
n = 2
logs = [&quot;0:start:0&quot;,&quot;1:start:2&quot;,&quot;1:end:5&quot;,&quot;0:end:6&quot;]
Output: [3, 4]
Explanation:
Function 0 starts at the beginning of time 0, then it executes 2 units of time and reaches the end of time 1.
Now function 1 starts at the beginning of time 2, executes 4 units of time and ends at time 5.
Function 0 is running again at the beginning of time 6, and also ends at the end of time 6, thus executing for 1 unit of time. 
So function 0 spends 2 + 1 = 3 units of total time executing, and function 1 spends 4 units of total time executing.


&#xA0;

Note:


	1 &lt;= n &lt;= 100
	Two functions won&apos;t start or end at the same time.
	Functions will always log when they exit.


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution636
{
    public class Solution
    {
        public void Init() { }

        public int[] ExclusiveTime(int n, IList<string> logs) { }
    }
}
