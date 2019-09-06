// Url:https://leetcode.com/problems/minimize-malware-spread-ii

/*
928. Minimize Malware Spread II
Hard

(This problem is the same as Minimize Malware Spread, with the differences bolded.)

In a network of nodes, each node i is directly connected to another node j if and only if&#xA0;graph[i][j] = 1.

Some nodes initial are initially infected by malware.&#xA0; Whenever two nodes are directly connected and at least one of those two nodes is infected by malware, both nodes will be infected by malware.&#xA0; This spread of malware will continue until no more nodes can be infected in this manner.

Suppose M(initial)&#xA0;is the final number of nodes infected with malware in the entire network, after the spread of malware stops.

We will&#xA0;remove one node from the initial list, completely removing it and any connections from this node to any other node.&#xA0; Return the node that if removed, would minimize&#xA0;M(initial).&#xA0; If multiple nodes could be removed to minimize M(initial), return such a node with the smallest index.

&#xA0;





Example 1:

Input: graph = [[1,1,0],[1,1,0],[0,0,1]], initial = [0,1]
Output: 0



Example 2:

Input: graph = [[1,1,0],[1,1,1],[0,1,1]], initial = [0,1]
Output: 1



Example 3:

Input: graph = [[1,1,0,0],[1,1,1,0],[0,1,1,1],[0,0,1,1]], initial = [0,1]
Output: 1


&#xA0;

Note:


	1 &lt; graph.length = graph[0].length &lt;= 300
	0 &lt;= graph[i][j] == graph[j][i] &lt;= 1
	graph[i][i] = 1
	1 &lt;= initial.length &lt; graph.length
	0 &lt;= initial[i] &lt; graph.length
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution928
{
    public class Solution
    {
        public void Init() { }

        public int MinMalwareSpread(int[][] graph, int[] initial) { }
    }
}
