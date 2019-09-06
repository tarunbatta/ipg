// Url:https://leetcode.com/problems/cat-and-mouse

/*
913. Cat and Mouse
Hard

A game on an undirected graph is played by two players, Mouse and Cat, who alternate turns.

The graph is given as follows: graph[a] is a list of all nodes b such that ab is an edge of the graph.

Mouse starts at node 1 and goes first, Cat starts at node 2 and goes second, and there is a Hole at node 0.

During each player&apos;s turn, they must travel along one&#xA0;edge of the graph that meets where they are.&#xA0; For example, if the Mouse is at node 1, it must travel to any node in graph[1].

Additionally, it is not allowed for the Cat to travel to the Hole (node 0.)

Then, the game can end in 3 ways:


	If ever the Cat occupies the same node as the Mouse, the Cat wins.
	If ever the Mouse reaches the Hole, the Mouse wins.
	If ever a position is repeated (ie.&#xA0;the players are in the same position as a previous turn, and&#xA0;it is the same player&apos;s turn to move), the game is a draw.


Given a graph, and assuming both players play optimally, return 1&#xA0;if the game is won by Mouse, 2&#xA0;if the game is won by Cat, and 0&#xA0;if the game is a draw.

&#xA0;





Example 1:

Input: [[2,5],[3],[0,4,5],[1,4,5],[2,3],[0,2,3]]
Output: 0
Explanation:
4---3---1
|&#xA0; &#xA0;|
2---5
&#xA0;\&#xA0;/
&#xA0; 0


&#xA0;

Note:


	3 &lt;= graph.length &lt;= 50
	It is guaranteed that graph[1] is non-empty.
	It is guaranteed that graph[2] contains a non-zero element.&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution913
{
    public class Solution
    {
        public void Init() { }

        public int CatMouseGame(int[][] graph) { }
    }
}
