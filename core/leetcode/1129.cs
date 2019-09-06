// Url:https://leetcode.com/problems/shortest-path-with-alternating-colors

/*
1129. Shortest Path with Alternating Colors
Medium

Consider a directed graph, with nodes labelled 0, 1, ..., n-1.&#xA0; In this graph, each edge is either red or blue, and there could&#xA0;be self-edges or parallel edges.

Each [i, j] in red_edges denotes a red directed edge from node i to node j.&#xA0; Similarly, each [i, j] in blue_edges denotes a blue directed edge from node i to node j.

Return an array answer&#xA0;of length n,&#xA0;where each&#xA0;answer[X]&#xA0;is&#xA0;the length of the shortest path from node 0&#xA0;to node X&#xA0;such that the edge colors alternate along the path (or -1 if such a path doesn&apos;t exist).

&#xA0;
Example 1:
Input: n = 3, red_edges = [[0,1],[1,2]], blue_edges = []
Output: [0,1,-1]
Example 2:
Input: n = 3, red_edges = [[0,1]], blue_edges = [[2,1]]
Output: [0,1,-1]
Example 3:
Input: n = 3, red_edges = [[1,0]], blue_edges = [[2,1]]
Output: [0,-1,-1]
Example 4:
Input: n = 3, red_edges = [[0,1]], blue_edges = [[1,2]]
Output: [0,1,2]
Example 5:
Input: n = 3, red_edges = [[0,1],[0,2]], blue_edges = [[1,0]]
Output: [0,1,1]

&#xA0;
Constraints:


	1 &lt;= n &lt;= 100
	red_edges.length &lt;= 400
	blue_edges.length &lt;= 400
	red_edges[i].length == blue_edges[i].length == 2
	0 &lt;= red_edges[i][j], blue_edges[i][j] &lt; n
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1129
{
    public class Solution
    {
        public void Init() { }

        public int[] ShortestAlternatingPaths(int n, int[][] red_edges, int[][] blue_edges) { }
    }
}
