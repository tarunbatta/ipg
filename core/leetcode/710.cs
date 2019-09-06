// Url:https://leetcode.com/problems/random-pick-with-blacklist

/*
710. Random Pick with Blacklist
Hard

Given a blacklist&#xA0;B containing unique integers&#xA0;from [0, N), write a function to return a uniform random integer from [0, N) which is NOT&#xA0;in B.

Optimize it such that it minimizes the call to system&#x2019;s Math.random().

Note:


	1 &lt;= N &lt;= 1000000000
	0 &lt;= B.length &lt; min(100000, N)
	[0, N)&#xA0;does NOT include N. See interval notation.


Example 1:

Input: 
[&quot;Solution&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;]
[[1,[]],[],[],[]]
Output: [null,0,0,0]


Example 2:

Input: 
[&quot;Solution&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;]
[[2,[]],[],[],[]]
Output: [null,1,1,1]


Example 3:

Input: 
[&quot;Solution&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;]
[[3,[1]],[],[],[]]
Output: [null,0,0,2]


Example 4:

Input: 
[&quot;Solution&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;]
[[4,[2]],[],[],[]]
Output: [null,1,3,1]


Explanation of Input Syntax:

The input is two lists:&#xA0;the subroutines called&#xA0;and their&#xA0;arguments.&#xA0;Solution&apos;s&#xA0;constructor has two arguments,&#xA0;N and the blacklist B. pick has no arguments.&#xA0;Arguments&#xA0;are&#xA0;always wrapped with a list, even if there aren&apos;t any.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution710
{
    public class Solution
    {
        public void Init() { }

​    public Solution(int N, int[] blacklist) { }
        public int Pick() { }
    }​/** * Your Solution object will be instantiated and called as such: * Solution obj = new Solution(N, blacklist); * int param_1 = obj.Pick(); *
}
