// Url:https://leetcode.com/problems/last-stone-weight-ii

/*
1049. Last Stone Weight II
Medium

We have a collection of rocks, each rock has a positive integer weight.

Each turn, we choose any two rocks&#xA0;and smash them together.&#xA0; Suppose the stones have weights x and y with x &lt;= y.&#xA0; The result of this smash is:


	If x == y, both stones are totally destroyed;
	If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y-x.


At the end, there is at most 1 stone left.&#xA0; Return the smallest possible weight of this stone (the weight is&#xA0;0 if there are no stones left.)

&#xA0;

Example 1:

Input: [2,7,4,1,8,1]
Output: 1
Explanation: 
We can combine 2 and 4 to get 2 so the array converts to [2,7,1,8,1] then,
we can combine 7 and 8 to get 1 so the array converts to [2,1,1,1] then,
we can combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
we can combine 1 and 1 to get 0 so the array converts to [1] then that&apos;s the optimal value.


&#xA0;

Note:


	1 &lt;= stones.length &lt;= 30
	1 &lt;= stones[i] &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1049
{
    public class Solution
    {
        public void Init() { }

        public int LastStoneWeightII(int[] stones) { }
    }
}
