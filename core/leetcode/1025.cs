// Url:https://leetcode.com/problems/divisor-game

/*
1025. Divisor Game
Easy

Alice and Bob take turns playing a game, with Alice starting first.

Initially, there is a number N&#xA0;on the chalkboard.&#xA0; On each player&apos;s turn, that player makes a move&#xA0;consisting of:


	Choosing&#xA0;any x with 0 &lt; x &lt; N and N % x == 0.
	Replacing&#xA0;the number&#xA0;N&#xA0;on the chalkboard with N - x.


Also, if a player cannot make a move, they lose the game.

Return True if and only if Alice wins the game, assuming both players play optimally.

&#xA0;





Example 1:

Input: 2
Output: true
Explanation: Alice chooses 1, and Bob has no more moves.



Example 2:

Input: 3
Output: false
Explanation: Alice chooses 1, Bob chooses 1, and Alice has no more moves.


&#xA0;

Note:


	1 &lt;= N &lt;= 1000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1025
{
    public class Solution
    {
        public void Init() { }

        public bool DivisorGame(int N) { }
    }
}
