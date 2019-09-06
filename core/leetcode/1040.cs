// Url:https://leetcode.com/problems/moving-stones-until-consecutive-ii

/*
1040. Moving Stones Until Consecutive II
Medium

On an infinite number line, the position of the i-th stone is given by&#xA0;stones[i].&#xA0; Call a stone an endpoint stone if it has the smallest or largest position.

Each turn, you pick up an endpoint stone and move it to an unoccupied position so that it is no longer an endpoint stone.

In particular,&#xA0;if the stones are at say, stones = [1,2,5], you cannot move the endpoint stone at position 5, since moving it to any position (such as 0, or 3) will still keep that stone as an endpoint stone.

The game ends when you cannot make any more moves, ie. the stones are in consecutive positions.

When the game ends, what is the minimum and maximum number of moves that you could have made?&#xA0; Return the answer as an length 2 array:&#xA0;answer = [minimum_moves, maximum_moves]

&#xA0;

Example 1:

Input: [7,4,9]
Output: [1,2]
Explanation: 
We can move 4 -&gt; 8 for one move to finish the game.
Or, we can move 9 -&gt; 5, 4 -&gt; 6 for two moves to finish the game.



Example 2:

Input: [6,5,4,3,10]
Output: [2,3]
We can move 3 -&gt; 8 then 10 -&gt; 7 to finish the game.
Or, we can move 3 -&gt; 7, 4 -&gt; 8, 5 -&gt; 9 to finish the game.
Notice we cannot move 10 -&gt; 2 to finish the game, because that would be an illegal move.



Example 3:

Input: [100,101,104,102,103]
Output: [0,0]

&#xA0;



Note:


	3 &lt;= stones.length &lt;= 10^4
	1 &lt;= stones[i] &lt;= 10^9
	stones[i] have distinct values.




&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1040
{
    public class Solution
    {
        public void Init() { }

        public int[] NumMovesStonesII(int[] stones) { }
    }
}
