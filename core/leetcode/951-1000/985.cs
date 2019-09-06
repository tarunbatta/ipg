// Url:https://leetcode.com/problems/sum-of-even-numbers-after-queries

/*
985. Sum of Even Numbers After Queries
Easy

We have an array A of integers, and an array queries&#xA0;of queries.

For the i-th&#xA0;query val =&#xA0;queries[i][0], index&#xA0;= queries[i][1], we add val&#xA0;to A[index].&#xA0; Then, the answer to the i-th query is the sum of the even values of A.

(Here, the given index = queries[i][1] is a 0-based index, and each query permanently modifies the array A.)

Return the answer to all queries.&#xA0; Your answer array should have&#xA0;answer[i]&#xA0;as&#xA0;the answer to the i-th query.

&#xA0;

Example 1:

Input: A = [1,2,3,4], queries = [[1,0],[-3,1],[-4,0],[2,3]]
Output: [8,6,2,4]
Explanation: 
At the beginning, the array is [1,2,3,4].
After adding 1 to A[0], the array is [2,2,3,4], and the sum of even values is 2 + 2 + 4 = 8.
After adding -3 to A[1], the array is [2,-1,3,4], and the sum of even values is 2 + 4 = 6.
After adding -4 to A[0], the array is [-2,-1,3,4], and the sum of even values is -2 + 4 = 2.
After adding 2 to A[3], the array is [-2,-1,3,6], and the sum of even values is -2 + 6 = 4.


&#xA0;

Note:


	1 &lt;= A.length &lt;= 10000
	-10000 &lt;= A[i] &lt;= 10000
	1 &lt;= queries.length &lt;= 10000
	-10000 &lt;= queries[i][0] &lt;= 10000
	0 &lt;= queries[i][1] &lt; A.length
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution985
{
    public class Solution
    {
        public void Init() { }

        public int[] SumEvenAfterQueries(int[] A, int[][] queries) { }
    }
}
