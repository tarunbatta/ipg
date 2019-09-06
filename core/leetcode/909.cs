// Url:https://leetcode.com/problems/snakes-and-ladders

/*
909. Snakes and Ladders
Medium

On an N x N board, the numbers from 1 to N*N are written&#xA0;boustrophedonically&#xA0;starting from the bottom&#xA0;left of the board, and alternating direction each row.&#xA0; For example, for a 6 x 6 board, the numbers are written as follows:




You start on square 1 of the board (which is always in the last row and&#xA0;first column).&#xA0; Each move, starting from square x, consists of the following:


	You choose a destination square S with number&#xA0;x+1, x+2, x+3, x+4, x+5, or x+6, provided this&#xA0;number is&#xA0;&lt;=&#xA0;N*N.

	
		(This choice simulates the result of a standard 6-sided die roll: ie., there are always at most 6 destinations, regardless of the size of the board.)
	
	
	If S&#xA0;has a snake or ladder, you move to the destination of that snake or ladder.&#xA0; Otherwise, you move to S.


A board square on row r and column c&#xA0;has a &quot;snake or ladder&quot; if board[r][c] != -1.&#xA0; The destination of that snake or ladder is board[r][c].

Note that you only take a snake or ladder at most once per move: if the destination to a snake or ladder is the start of another&#xA0;snake or ladder, you do not continue moving.&#xA0; (For example, if the board is `[[4,-1],[-1,3]]`, and on the first move your destination square is `2`, then you finish your first move at&#xA0;`3`, because you do not continue moving to `4`.)

Return the least number of moves required to reach square N*N.&#xA0; If it is not possible, return -1.

Example 1:

Input: [
[-1,-1,-1,-1,-1,-1],
[-1,-1,-1,-1,-1,-1],
[-1,-1,-1,-1,-1,-1],
[-1,35,-1,-1,13,-1],
[-1,-1,-1,-1,-1,-1],
[-1,15,-1,-1,-1,-1]]
Output: 4
Explanation: 
At the beginning, you start at square 1 [at row 5, column 0].
You decide to move to square 2, and must take the ladder to square 15.
You then decide to move to square 17 (row 3, column 5), and must take the snake to square 13.
You then decide to move to square 14, and must take the ladder to square 35.
You then decide to move to square 36, ending the game.
It can be shown that you need at least 4 moves to reach the N*N-th square, so the answer is 4.


Note:


	2 &lt;= board.length = board[0].length&#xA0;&lt;= 20
	board[i][j]&#xA0;is between 1 and N*N or is equal to -1.
	The board&#xA0;square with number 1 has no snake or ladder.
	The board square with number N*N has no snake or ladder.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution909
{
    public class Solution
    {
        public void Init() { }

        public int SnakesAndLadders(int[][] board) { }
    }
}
