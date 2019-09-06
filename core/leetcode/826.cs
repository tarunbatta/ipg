// Url:https://leetcode.com/problems/most-profit-assigning-work

/*
826. Most Profit Assigning Work
Medium

We have jobs: difficulty[i]&#xA0;is the difficulty of the&#xA0;ith job, and&#xA0;profit[i]&#xA0;is the profit of the&#xA0;ith job.&#xA0;

Now we have some workers.&#xA0;worker[i]&#xA0;is the ability of the&#xA0;ith worker, which means that this worker can only complete a job with difficulty at most&#xA0;worker[i].&#xA0;

Every worker can be assigned at most one job, but one job&#xA0;can be completed multiple times.

For example, if 3 people attempt the same job that pays $1, then the total profit will be $3.&#xA0; If a worker cannot complete any job, his profit is $0.

What is the most profit we can make?

Example 1:

Input: difficulty = [2,4,6,8,10], profit = [10,20,30,40,50], worker = [4,5,6,7]
Output: 100 
Explanation: Workers are assigned jobs of difficulty [4,4,6,6] and they get profit of [20,20,30,30] seperately.

Notes:


	1 &lt;= difficulty.length = profit.length &lt;= 10000
	1 &lt;= worker.length &lt;= 10000
	difficulty[i], profit[i], worker[i]&#xA0; are in range&#xA0;[1, 10^5]
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution826
{
    public class Solution
    {
        public void Init() { }

        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) { }
    }
}
