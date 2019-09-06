// Url:https://leetcode.com/problems/network-delay-time

/*
743. Network Delay Time
Medium

There are N network nodes, labelled 1 to N.

Given times, a list of travel times as directed edges times[i] = (u, v, w), where u is the source node, v is the target node, and w is the time it takes for a signal to travel from source to target.

Now, we send a signal from a certain node K. How long will it take for all nodes to receive the signal? If it is impossible, return -1.

&#xA0;

Example 1:



Input: times = [[2,1,1],[2,3,1],[3,4,1]], N = 4, K = 2
Output: 2


&#xA0;

Note:


	N will be in the range [1, 100].
	K will be in the range [1, N].
	The length of times will be in the range [1, 6000].
	All edges times[i] = (u, v, w) will have 1 &lt;= u, v &lt;= N and 0 &lt;= w &lt;= 100.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution743
{
    public class Solution
    {
        public void Init() { }

        public int NetworkDelayTime(int[][] times, int N, int K) { }
    }
}
