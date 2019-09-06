// Url:https://leetcode.com/problems/dungeon-game

/*
174. Dungeon Game
Hard

table.dungeon, .dungeon th, .dungeon td {
  border:3px solid black;
}

 .dungeon th, .dungeon td {
    text-align: center;
    height: 70px;
    width: 70px;
}

The demons had captured the princess (P) and imprisoned her in the bottom-right corner of a dungeon. The dungeon consists of M x N rooms laid out in a 2D grid. Our valiant knight (K) was initially positioned in the top-left room and must fight his way through the dungeon to rescue the princess.

The knight has an initial health point represented by a positive integer. If at any point his health point drops to 0 or below, he dies immediately.

Some of the rooms are guarded by demons, so the knight loses health (negative integers) upon entering these rooms; other rooms are either empty (0&apos;s) or contain magic orbs that increase the knight&apos;s health (positive integers).

In order to reach the princess as quickly as possible, the knight decides to move only rightward or downward in each step.

&#xA0;

Write a function to determine the knight&apos;s minimum initial health so that he is able to rescue the princess.

For example, given the dungeon below, the initial health of the knight must be at least 7 if he follows the optimal path RIGHT-&gt; RIGHT -&gt; DOWN -&gt; DOWN.


	
		
			-2 (K)
			-3
			3
		
		
			-5
			-10
			1
		
		
			10
			30
			-5 (P)
		
	


&#xA0;

Note:


	The knight&apos;s health has no upper bound.
	Any room can contain threats or power-ups, even the first room the knight enters and the bottom-right room where the princess is imprisoned.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution174
{
    public class Solution
    {
        public void Init() { }

        public int CalculateMinimumHP(int[][] dungeon) { }
    }
}
