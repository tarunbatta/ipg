// Url:https://leetcode.com/problems/reachable-nodes-in-subdivided-graph

/*
882. Reachable Nodes In Subdivided Graph
Hard

Starting with an&#xA0;undirected graph (the &quot;original graph&quot;) with nodes from 0 to N-1, subdivisions are made to some of the edges.

The graph is given as follows: edges[k] is a list of integer pairs (i, j, n) such that (i, j) is an edge of the original graph,

and n is the total number of new nodes on that edge.&#xA0;

Then, the edge (i, j) is deleted from the original graph,&#xA0;n&#xA0;new nodes (x_1, x_2, ..., x_n) are added to the original graph,

and n+1 new&#xA0;edges (i, x_1), (x_1, x_2), (x_2, x_3), ..., (x_{n-1}, x_n), (x_n, j)&#xA0;are added to the original&#xA0;graph.

Now, you start at node 0&#xA0;from the original graph, and in each move, you travel along one&#xA0;edge.&#xA0;

Return how many nodes you can reach in at most M moves.

&#xA0;

Example 1:

Input: edges = [[0,1,10],[0,2,1],[1,2,2]], M = 6, N = 3
Output: 13
Explanation: 
The nodes that are reachable in the final graph after M = 6 moves are indicated below.




Example 2:

Input: edges = [[0,1,4],[1,2,6],[0,2,8],[1,3,1]], M = 10, N = 4
Output: 23

&#xA0;


Note:


	0 &lt;= edges.length &lt;= 10000
	0 &lt;= edges[i][0] &lt;&#xA0;edges[i][1] &lt; N
	There does not exist any&#xA0;i != j for which edges[i][0] == edges[j][0] and edges[i][1] == edges[j][1].
	The original graph&#xA0;has no parallel edges.
	0 &lt;= edges[i][2] &lt;= 10000
	0 &lt;= M &lt;= 10^9
	1 &lt;= N &lt;= 3000
	A reachable node is a node that can be travelled to&#xA0;using at most&#xA0;M moves starting from&#xA0;node 0.



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution882
{
    public class Solution
    {
        public void Init() { }

        public int ReachableNodes(int[][] edges, int M, int N) { }
    }
}
