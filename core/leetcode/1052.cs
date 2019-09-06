// Url:https://leetcode.com/problems/grumpy-bookstore-owner

/*
1052. Grumpy Bookstore Owner
Medium

Today, the bookstore owner has a store open for customers.length minutes.&#xA0; Every minute, some number of customers (customers[i]) enter the store, and all those customers leave after the end of that minute.

On some minutes, the bookstore owner is grumpy.&#xA0; If the bookstore owner is grumpy on the i-th minute, grumpy[i] = 1, otherwise grumpy[i] = 0.&#xA0; When the bookstore owner is grumpy, the customers of that minute are not satisfied, otherwise they are satisfied.

The bookstore owner knows a secret technique to keep themselves&#xA0;not grumpy for X&#xA0;minutes straight, but can only use it once.

Return the maximum number of customers that can be satisfied throughout the day.

&#xA0;

Example 1:

Input: customers = [1,0,1,2,1,1,7,5], grumpy = [0,1,0,1,0,1,0,1], X = 3
Output: 16
Explanation:&#xA0;The bookstore owner keeps themselves&#xA0;not grumpy for the last 3 minutes. 
The maximum number of customers that can be satisfied = 1 + 1 + 1 + 1 + 7 + 5 = 16.


&#xA0;

Note:


	1 &lt;= X &lt;=&#xA0;customers.length ==&#xA0;grumpy.length &lt;= 20000
	0 &lt;=&#xA0;customers[i] &lt;= 1000
	0 &lt;=&#xA0;grumpy[i] &lt;= 1
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1052
{
    public class Solution
    {
        public void Init() { }

        public int MaxSatisfied(int[] customers, int[] grumpy, int X) { }
    }
}
