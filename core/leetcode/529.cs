// Url:https://leetcode.com/problems/minesweeper

/*
529. Minesweeper
Medium

Let&apos;s play the minesweeper game (Wikipedia, online game)!

You are given a 2D char matrix representing the game board. &apos;M&apos; represents an unrevealed mine, &apos;E&apos; represents an unrevealed empty square, &apos;B&apos; represents a revealed blank square that has no adjacent (above, below, left, right, and all 4 diagonals) mines, digit (&apos;1&apos; to &apos;8&apos;) represents how many mines are adjacent to this revealed square, and finally &apos;X&apos; represents a revealed mine.

Now given the next click position (row and column indices) among all the unrevealed squares (&apos;M&apos; or &apos;E&apos;), return the board after revealing this position according to the following rules:


	If a mine (&apos;M&apos;) is revealed, then the game is over - change it to &apos;X&apos;.
	If an empty square (&apos;E&apos;) with no adjacent mines is revealed, then change it to revealed blank (&apos;B&apos;) and all of its adjacent unrevealed squares should be revealed recursively.
	If an empty square (&apos;E&apos;) with at least one adjacent mine is revealed, then change it to a digit (&apos;1&apos; to &apos;8&apos;) representing the number of adjacent mines.
	Return the board when no more squares will be revealed.


&#xA0;

Example 1:

Input: 

[[&apos;E&apos;, &apos;E&apos;, &apos;E&apos;, &apos;E&apos;, &apos;E&apos;],
 [&apos;E&apos;, &apos;E&apos;, &apos;M&apos;, &apos;E&apos;, &apos;E&apos;],
 [&apos;E&apos;, &apos;E&apos;, &apos;E&apos;, &apos;E&apos;, &apos;E&apos;],
 [&apos;E&apos;, &apos;E&apos;, &apos;E&apos;, &apos;E&apos;, &apos;E&apos;]]

Click : [3,0]

Output: 

[[&apos;B&apos;, &apos;1&apos;, &apos;E&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;1&apos;, &apos;M&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;1&apos;, &apos;1&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;B&apos;, &apos;B&apos;, &apos;B&apos;, &apos;B&apos;]]

Explanation:



Example 2:

Input: 

[[&apos;B&apos;, &apos;1&apos;, &apos;E&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;1&apos;, &apos;M&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;1&apos;, &apos;1&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;B&apos;, &apos;B&apos;, &apos;B&apos;, &apos;B&apos;]]

Click : [1,2]

Output: 

[[&apos;B&apos;, &apos;1&apos;, &apos;E&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;1&apos;, &apos;X&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;1&apos;, &apos;1&apos;, &apos;1&apos;, &apos;B&apos;],
 [&apos;B&apos;, &apos;B&apos;, &apos;B&apos;, &apos;B&apos;, &apos;B&apos;]]

Explanation:



&#xA0;

Note:


	The range of the input matrix&apos;s height and width is [1,50].
	The click position will only be an unrevealed square (&apos;M&apos; or &apos;E&apos;), which also means the input board contains at least one clickable square.
	The input board won&apos;t be a stage when game is over (some mines have been revealed).
	For simplicity, not mentioned rules should be ignored in this problem. For example, you don&apos;t need to reveal all the unrevealed mines when the game is over, consider any cases that you will win the game or flag any squares.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution529
{
    public class Solution
    {
        public void Init() { }

        public char[][] UpdateBoard(char[][] board, int[] click) { }
    }
}
