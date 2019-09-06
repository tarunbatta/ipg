// Url:https://leetcode.com/problems/rle-iterator

/*
900. RLE Iterator
Medium

Write an iterator that iterates through a run-length encoded sequence.

The iterator is initialized by RLEIterator(int[] A), where A is a run-length encoding of some&#xA0;sequence.&#xA0; More specifically,&#xA0;for all even i,&#xA0;A[i] tells us the number of times that the non-negative integer value A[i+1] is repeated in the sequence.

The iterator supports one function:&#xA0;next(int n), which exhausts the next n elements&#xA0;(n &gt;= 1) and returns the last element exhausted in this way.&#xA0; If there is no element left to exhaust, next&#xA0;returns -1 instead.

For example, we start with A = [3,8,0,9,2,5], which is a run-length encoding of the sequence [8,8,8,5,5].&#xA0; This is because the sequence can be read as&#xA0;&quot;three eights, zero nines, two fives&quot;.

&#xA0;

Example 1:

Input: [&quot;RLEIterator&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;], [[[3,8,0,9,2,5]],[2],[1],[1],[2]]
Output: [null,8,8,5,-1]
Explanation: 
RLEIterator is initialized with RLEIterator([3,8,0,9,2,5]).
This maps to the sequence [8,8,8,5,5].
RLEIterator.next is then called 4 times:

.next(2) exhausts 2 terms of the sequence, returning 8.  The remaining sequence is now [8, 5, 5].

.next(1) exhausts 1 term of the sequence, returning 8.  The remaining sequence is now [5, 5].

.next(1) exhausts 1 term of the sequence, returning 5.  The remaining sequence is now [5].

.next(2) exhausts 2 terms, returning -1.  This is because the first term exhausted was 5,
but the second term did not exist.  Since the last term exhausted does not exist, we return -1.



Note:


	0 &lt;= A.length &lt;= 1000
	A.length&#xA0;is an even integer.
	0 &lt;= A[i] &lt;= 10^9
	There are at most 1000 calls to RLEIterator.next(int n) per test case.
	Each call to&#xA0;RLEIterator.next(int n)&#xA0;will have 1 &lt;= n &lt;= 10^9.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution900
{
    public class RLEIterator {​    public RLEIterator(int[] A) { } public int Next(int n) { } }​/** * Your RLEIterator object will be instantiated and called as such: * RLEIterator obj = new RLEIterator(A); * int param_1 = obj.Next(n); *
}
