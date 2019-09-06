// Url:https://leetcode.com/problems/stone-game-ii

/*
1140. Stone Game II
Medium

Alex&#xA0;and Lee continue their&#xA0;games with piles of stones.&#xA0; There are a number of&#xA0;piles&#xA0;arranged in a row, and each pile has a positive integer number of stones&#xA0;piles[i].&#xA0; The objective of the game is to end with the most&#xA0;stones.&#xA0;

Alex and Lee take turns, with Alex starting first.&#xA0; Initially, M = 1.

On each player&apos;s turn, that player&#xA0;can take all the stones in the first X remaining piles, where 1 &lt;= X &lt;= 2M.&#xA0; Then, we set&#xA0;M = max(M, X).

The game continues until all the stones have been taken.

Assuming Alex and Lee play optimally, return the maximum number of stones Alex can get.

&#xA0;
Example 1:

Input: piles = [2,7,9,4,4]
Output: 10
Explanation:  If Alex takes one pile at the beginning, Lee takes two piles, then Alex takes 2 piles again. Alex can get 2 + 4 + 4 = 10 piles in total. If Alex takes two piles at the beginning, then Lee can take all three piles left. In this case, Alex get 2 + 7 = 9 piles in total. So we return 10 since it&apos;s larger. 


&#xA0;
Constraints:


	1 &lt;= piles.length &lt;= 100
	1 &lt;= piles[i]&#xA0;&lt;= 10 ^ 4
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1140
{
    public class Solution
    {
        public void Init() { }

        public int StoneGameII(int[] piles) { }
    }
}
