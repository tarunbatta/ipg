// Url:https://leetcode.com/problems/battleships-in-a-board

/*
419. Battleships in a Board
Medium

Given an 2D board, count how many battleships are in it. The battleships are represented with &apos;X&apos;s, empty slots are represented with &apos;.&apos;s. You may assume the following rules:


You receive a valid board, made of only battleships or empty slots.
Battleships can only be placed horizontally or vertically. In other words, they can only be made of the shape 1xN (1 row, N columns) or Nx1 (N rows, 1 column), where N can be of any size.
At least one horizontal or vertical cell separates between two battleships - there are no adjacent battleships.


Example:
X..X
...X
...X

In the above board there are 2 battleships.

Invalid Example:
...X
XXXX
...X

This is an invalid board that you will not receive - as battleships will always have a cell separating between them.

Follow up:Could you do it in one-pass, using only O(1) extra memory and without modifying the value of the board?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution419 {
    public class Solution {
        public void Init () {

        }

        public int CountBattleships (char[][] board) {
            return 0;
        }
    }
}