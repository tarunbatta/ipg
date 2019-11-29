// Url:https://leetcode.com/problems/partition-array-into-disjoint-intervals

/*
915. Partition Array into Disjoint Intervals
Medium

Given an array A, partition it into two (contiguous) subarrays left and right so that:


	Every element in left is less than or equal to every element in right.
	left and right are non-empty.
	left has the smallest possible size.


Return the length of left after such a partitioning.  It is guaranteed that such a partitioning exists.

 

Example 1:

Input: [5,0,3,8,6]
Output: 3
Explanation: left = [5,0,3], right = [8,6]



Example 2:

Input: [1,1,1,0,6,12]
Output: 4
Explanation: left = [1,1,1,0], right = [6,12]


 


Note:


	2 <= A.length <= 30000
	0 <= A[i] <= 10^6
	It is guaranteed there is at least one way to partition A as described.



 
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem915
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        // Time: O ()
        // Space: O ()
        public int PartitionDisjoint(int[] A)
        {
            return 0;
        }
    }
}