// Url:https://leetcode.com/problems/clone-graph

/*
133. Clone Graph
Medium

Given&#xA0;a reference of a node in a&#xA0;connected&#xA0;undirected graph, return a deep copy (clone) of the graph. Each node in the graph contains a val (int) and a list (List[Node]) of its neighbors.

&#xA0;

Example:



Input:
{&quot;$id&quot;:&quot;1&quot;,&quot;neighbors&quot;:[{&quot;$id&quot;:&quot;2&quot;,&quot;neighbors&quot;:[{&quot;$ref&quot;:&quot;1&quot;},{&quot;$id&quot;:&quot;3&quot;,&quot;neighbors&quot;:[{&quot;$ref&quot;:&quot;2&quot;},{&quot;$id&quot;:&quot;4&quot;,&quot;neighbors&quot;:[{&quot;$ref&quot;:&quot;3&quot;},{&quot;$ref&quot;:&quot;1&quot;}],&quot;val&quot;:4}],&quot;val&quot;:3}],&quot;val&quot;:2},{&quot;$ref&quot;:&quot;4&quot;}],&quot;val&quot;:1}

Explanation:
Node 1&apos;s value is 1, and it has two neighbors: Node 2 and 4.
Node 2&apos;s value is 2, and it has two neighbors: Node 1 and 3.
Node 3&apos;s value is 3, and it has two neighbors: Node 2 and 4.
Node 4&apos;s value is 4, and it has two neighbors: Node 1 and 3.


&#xA0;

Note:


	The number of nodes will be between 1 and 100.
	The undirected&#xA0;graph is a simple graph,&#xA0;which means no repeated edges and no self-loops in the graph.
	Since the graph is undirected, if node p&#xA0;has node q&#xA0;as&#xA0;neighbor, then node q&#xA0;must have node p&#xA0;as neighbor too.
	You must return the copy of the given node as a reference to the cloned graph.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution133
{
    /*// Definition for a Node.public class Node {    public int val;    public IList<Node> neighbors;​    public Node(){}    public Node(int _val,IList<Node> _neighbors) {        val = _val;        neighbors = _neighbors;}*/
    public class Solution
    {
        public void Init() { }

        public Node CloneGraph(Node node) { }
    }
}
