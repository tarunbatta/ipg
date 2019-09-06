// Url:https://leetcode.com/problems/flower-planting-with-no-adjacent

/*
1042. Flower Planting With No Adjacent
Easy

You have N gardens, labelled 1 to N.&#xA0; In each garden, you want to plant one of 4 types of flowers.

paths[i] = [x, y] describes the existence of a bidirectional path from garden x to garden y.

Also, there is no garden that has more than 3 paths coming into or leaving it.

Your task is to choose a flower type for each garden such that,&#xA0;for any two gardens connected by a path, they have different types of flowers.

Return any such a choice as an array answer, where&#xA0;answer[i] is the type of flower&#xA0;planted in the (i+1)-th garden.&#xA0; The flower types are denoted&#xA0;1, 2, 3, or 4.&#xA0; It is guaranteed an answer exists.

&#xA0;


Example 1:

Input: N = 3, paths = [[1,2],[2,3],[3,1]]
Output: [1,2,3]



Example 2:

Input: N = 4, paths = [[1,2],[3,4]]
Output: [1,2,1,2]



Example 3:

Input: N = 4, paths = [[1,2],[2,3],[3,4],[4,1],[1,3],[2,4]]
Output: [1,2,3,4]


&#xA0;

Note:


	1 &lt;= N &lt;= 10000
	0 &lt;= paths.size &lt;= 20000
	No garden has 4 or more paths coming into or leaving it.
	It is guaranteed an answer exists.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1042
{
    public class Solution
    {
        public void Init() { }

        public int[] GardenNoAdj(int N, int[][] paths) { }
    }
}
