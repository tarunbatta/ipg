// Url:https://leetcode.com/problems/minimum-cost-to-merge-stones

/*
1000. Minimum Cost to Merge Stones
Hard

There are N piles of stones arranged in a row.&#xA0; The i-th pile has stones[i] stones.

A move consists of merging exactly&#xA0;K&#xA0;consecutive piles into one pile, and the cost of this move is equal to the total number of stones in these K piles.

Find the minimum cost to merge all piles of stones into one pile.&#xA0; If it is impossible, return -1.

&#xA0;


Example 1:

Input: stones = [3,2,4,1], K = 2
Output: 20
Explanation: 
We start with [3, 2, 4, 1].
We merge [3, 2] for a cost of 5, and we are left with [5, 4, 1].
We merge [4, 1] for a cost of 5, and we are left with [5, 5].
We merge [5, 5] for a cost of 10, and we are left with [10].
The total cost was 20, and this is the minimum possible.



Example 2:

Input: stones = [3,2,4,1], K = 3
Output: -1
Explanation: After any merge operation, there are 2 piles left, and we can&apos;t merge anymore.  So the task is impossible.



Example 3:

Input: stones = [3,5,1,2,6], K = 3
Output: 25
Explanation: 
We start with [3, 5, 1, 2, 6].
We merge [5, 1, 2] for a cost of 8, and we are left with [3, 8, 6].
We merge [3, 8, 6] for a cost of 17, and we are left with [17].
The total cost was 25, and this is the minimum possible.


&#xA0;

Note:


	1 &lt;= stones.length &lt;= 30
	2 &lt;= K &lt;= 30
	1 &lt;= stones[i] &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1000
{
    public class Solution
    {
        public void Init() { }

        public int MergeStones(int[] stones, int K) { }
    }
}
