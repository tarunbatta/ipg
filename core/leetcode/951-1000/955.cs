// Url:https://leetcode.com/problems/delete-columns-to-make-sorted-ii

/*
955. Delete Columns to Make Sorted II
Medium

We are given an array&#xA0;A of N lowercase letter strings, all of the same length.

Now, we may choose any set of deletion indices, and for each string, we delete all the characters in those indices.

For example, if we have an array A = [&quot;abcdef&quot;,&quot;uvwxyz&quot;] and deletion indices {0, 2, 3}, then the final array after deletions is [&quot;bef&quot;,&quot;vyz&quot;].

Suppose we chose a set of deletion indices D such that after deletions, the final array has its elements in lexicographic order (A[0] &lt;= A[1] &lt;= A[2] ... &lt;= A[A.length - 1]).

Return the minimum possible value of D.length.

&#xA0;









Example 1:

Input: [&quot;ca&quot;,&quot;bb&quot;,&quot;ac&quot;]
Output: 1
Explanation: 
After deleting the first column, A = [&quot;a&quot;, &quot;b&quot;, &quot;c&quot;].
Now A is in lexicographic order (ie. A[0] &lt;= A[1] &lt;= A[2]).
We require at least 1 deletion since initially A was not in lexicographic order, so the answer is 1.



Example 2:

Input: [&quot;xc&quot;,&quot;yb&quot;,&quot;za&quot;]
Output: 0
Explanation: 
A is already in lexicographic order, so we don&apos;t need to delete anything.
Note that the rows of A are not necessarily in lexicographic order:
ie. it is NOT necessarily true that (A[0][0] &lt;= A[0][1] &lt;= ...)



Example 3:

Input: [&quot;zyx&quot;,&quot;wvu&quot;,&quot;tsr&quot;]
Output: 3
Explanation: 
We have to delete every column.


&#xA0;



Note:


	1 &lt;= A.length &lt;= 100
	1 &lt;= A[i].length &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution955
{
    public class Solution
    {
        public void Init() { }

        public int MinDeletionSize(string[] A) { }
    }
}
