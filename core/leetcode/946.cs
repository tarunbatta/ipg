// Url:https://leetcode.com/problems/validate-stack-sequences

/*
946. Validate Stack Sequences
Medium

Given two sequences pushed and popped&#xA0;with distinct values,&#xA0;return true if and only if this could have been the result of a sequence of push and pop operations on an initially empty stack.

&#xA0;


Example 1:

Input: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]
Output: true
Explanation: We might do the following sequence:
push(1), push(2), push(3), push(4), pop() -&gt; 4,
push(5), pop() -&gt; 5, pop() -&gt; 3, pop() -&gt; 2, pop() -&gt; 1



Example 2:

Input: pushed = [1,2,3,4,5], popped = [4,3,5,1,2]
Output: false
Explanation: 1 cannot be popped before 2.


&#xA0;

Note:


	0 &lt;= pushed.length == popped.length &lt;= 1000
	0 &lt;= pushed[i], popped[i] &lt; 1000
	pushed is a permutation of popped.
	pushed and popped have distinct values.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution946
{
    public class Solution
    {
        public void Init() { }

        public bool ValidateStackSequences(int[] pushed, int[] popped) { }
    }
}
