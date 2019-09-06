// Url:https://leetcode.com/problems/moving-stones-until-consecutive

/*
1033. Moving Stones Until Consecutive
Easy

Three stones are on a number line at positions a, b, and c.

Each turn, you pick up a stone at an endpoint (ie., either the lowest or highest position stone), and move it to an unoccupied position between those&#xA0;endpoints.&#xA0; Formally, let&apos;s say the stones are currently at positions x, y, z with x &lt; y &lt; z.&#xA0; You pick up the stone at either position x or position z, and move that stone to an integer position k, with x &lt; k &lt; z and k != y.

The game ends when you cannot make any more moves, ie. the stones are in consecutive positions.

When the game ends, what is the minimum and maximum number of moves that you could have made?&#xA0; Return the answer as an length 2 array: answer = [minimum_moves, maximum_moves]

&#xA0;

Example 1:

Input: a = 1, b = 2, c = 5
Output: [1,2]
Explanation: Move the stone from 5 to 3, or move the stone from 5 to 4 to 3.



Example 2:

Input: a = 4, b = 3, c = 2
Output: [0,0]
Explanation: We cannot make any moves.



Example 3:

Input: a = 3, b = 5, c = 1
Output: [1,2]
Explanation: Move the stone from 1 to 4; or move the stone from 1 to 2 to 4.


&#xA0;



Note:


	1 &lt;= a &lt;= 100
	1 &lt;= b &lt;= 100
	1 &lt;= c &lt;= 100
	a != b, b != c, c != a



&#xA0;


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1033
{
    public class Solution
    {
        public void Init() { }

        public int[] NumMovesStones(int a, int b, int c) { }
    }
}
