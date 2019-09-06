// Url:https://leetcode.com/problems/fruit-into-baskets

/*
904. Fruit Into Baskets
Medium

In a row of trees, the i-th tree&#xA0;produces&#xA0;fruit with type&#xA0;tree[i].

You start at any tree&#xA0;of your choice, then repeatedly perform the following steps:


	Add one piece of fruit from this tree to your baskets.&#xA0; If you cannot, stop.
	Move to the next tree to the right of the current tree.&#xA0; If there is no tree to the right, stop.


Note that you do not have any choice after the initial choice of starting tree:&#xA0;you must perform step 1, then step 2, then back to step 1, then step 2, and so on until you stop.

You have two baskets, and each basket can carry any quantity of fruit, but you want each basket to only carry one type of fruit each.

What is the total amount of fruit you can collect with this procedure?

&#xA0;

Example 1:

Input: [1,2,1]
Output: 3
Explanation: We can collect [1,2,1].



Example 2:

Input: [0,1,2,2]
Output: 3
Explanation: We can collect [1,2,2].
If we started at the first tree, we would only collect [0, 1].



Example 3:

Input: [1,2,3,2,2]
Output: 4
Explanation: We can collect [2,3,2,2].
If we started at the first tree, we would only collect [1, 2].



Example 4:

Input: [3,3,3,1,2,1,1,2,3,3,4]
Output: 5
Explanation: We can collect [1,2,1,1,2].
If we started at the first tree or the eighth tree, we would only collect 4 fruits.


&#xA0;




Note:


	1 &lt;= tree.length &lt;= 40000
	0 &lt;= tree[i] &lt; tree.length
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution904
{
    public class Solution
    {
        public void Init() { }

        public int TotalFruit(int[] tree) { }
    }
}
