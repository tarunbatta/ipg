// Url:https://leetcode.com/problems/binary-tree-coloring-game

/*
1145. Binary Tree Coloring Game
Medium

Two players play a turn based game on a binary tree.&#xA0; We are given&#xA0;the root of this binary tree, and the number of nodes n&#xA0;in the tree.&#xA0; n is odd, and&#xA0;each node has a distinct value from 1 to n.

Initially, the first player names a value x with 1 &lt;= x &lt;= n, and the second player names a value y with 1 &lt;= y &lt;= n and y != x.&#xA0; The first player colors the node with value x red, and the second player colors the node with value y blue.

Then, the players take turns starting with the first player.&#xA0; In each turn, that player chooses a node of their color (red if player 1, blue if player 2) and colors an uncolored neighbor of the chosen node (either the left child, right child, or parent of the chosen node.)

If (and only if)&#xA0;a player cannot choose such a node in this way, they must pass their turn.&#xA0; If both players pass their turn, the game ends, and the winner is the player that colored more nodes.

You are the second player.&#xA0; If it is possible to choose such a y&#xA0;to ensure you win the game, return true.&#xA0; If it is not possible, return false.

&#xA0;
Example 1:

Input: root = [1,2,3,4,5,6,7,8,9,10,11], n = 11, x = 3
Output: true
Explanation: The second player can choose the node with value 2.


&#xA0;
Constraints:


	root is the root of a binary tree with n nodes and distinct node values from 1 to n.
	n is odd.
	1 &lt;= x &lt;= n&#xA0;&lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1145
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public bool BtreeGameWinningMove(TreeNode root, int n, int x) { }
    }
}
