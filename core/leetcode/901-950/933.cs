// Url:https://leetcode.com/problems/number-of-recent-calls

/*
933. Number of Recent Calls
Easy

Write a class RecentCounter to count recent requests.

It has only one method:&#xA0;ping(int t), where t represents some time in milliseconds.

Return the number of pings that have been made from 3000 milliseconds ago until now.

Any ping with time in [t - 3000, t] will count, including the current ping.

It is guaranteed that every call to ping uses a strictly larger value of&#xA0;t than before.

&#xA0;

Example 1:

Input: inputs = [&quot;RecentCounter&quot;,&quot;ping&quot;,&quot;ping&quot;,&quot;ping&quot;,&quot;ping&quot;], inputs = [[],[1],[100],[3001],[3002]]
Output: [null,1,2,3,3]

&#xA0;

Note:


	Each test case will have at most 10000 calls to ping.
	Each test case will call&#xA0;ping with strictly increasing values of t.
	Each call to ping will have 1 &lt;= t &lt;= 10^9.



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution933
{
    public class RecentCounter {​    public RecentCounter() { } public int Ping(int t) { } }​/** * Your RecentCounter object will be instantiated and called as such: * RecentCounter obj = new RecentCounter(); * int param_1 = obj.Ping(t); *
}
