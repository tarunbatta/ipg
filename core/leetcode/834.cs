// Url:https://leetcode.com/problems/sum-of-distances-in-tree

/*
834. Sum of Distances in Tree
Hard

An undirected, connected&#xA0;tree with N nodes labelled 0...N-1 and N-1 edges&#xA0;are&#xA0;given.

The ith edge connects nodes&#xA0;edges[i][0] and&#xA0;edges[i][1]&#xA0;together.

Return a list ans, where ans[i] is the sum of the distances between node i and all other nodes.

Example 1:

Input: N = 6, edges = [[0,1],[0,2],[2,3],[2,4],[2,5]]
Output: [8,12,6,10,10,10]
Explanation: 
Here is a diagram of the given tree:
  0
 / \
1   2
   /|\
  3 4 5
We can see that dist(0,1) + dist(0,2) + dist(0,3) + dist(0,4) + dist(0,5)
equals 1 + 1 + 2 + 2 + 2 = 8.  Hence, answer[0] = 8, and so on.


Note:&#xA0;1 &lt;= N &lt;= 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution834
{
    public class Solution
    {
        public void Init() { }

        public int[] SumOfDistancesInTree(int N, int[][] edges) { }
    }
}
