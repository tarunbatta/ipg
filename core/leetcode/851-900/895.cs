// Url:https://leetcode.com/problems/maximum-frequency-stack

/*
895. Maximum Frequency Stack
Hard

Implement FreqStack, a class which simulates the operation of a stack-like data structure.

FreqStack&#xA0;has two functions:


	push(int x), which pushes an integer x onto the stack.
	pop(), which removes and returns the most frequent element in the stack.
	
		If there is a tie for most frequent element, the element closest to the top of the stack is removed and returned.
	
	


&#xA0;

Example 1:

Input: 
[&quot;FreqStack&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;pop&quot;,&quot;pop&quot;,&quot;pop&quot;,&quot;pop&quot;],
[[],[5],[7],[5],[7],[4],[5],[],[],[],[]]
Output: [null,null,null,null,null,null,null,5,7,5,4]
Explanation:
After making six .push operations, the stack is [5,7,5,7,4,5] from bottom to top.  Then:

pop() -&gt; returns 5, as 5 is the most frequent.
The stack becomes [5,7,5,7,4].

pop() -&gt; returns 7, as 5 and 7 is the most frequent, but 7 is closest to the top.
The stack becomes [5,7,5,4].

pop() -&gt; returns 5.
The stack becomes [5,7,4].

pop() -&gt; returns 4.
The stack becomes [5,7].


&#xA0;

Note:


	Calls to FreqStack.push(int x)&#xA0;will be such that 0 &lt;= x &lt;= 10^9.
	It is guaranteed that FreqStack.pop() won&apos;t be called if the stack has zero elements.
	The total number of FreqStack.push calls will not exceed 10000 in a single test case.
	The total number of FreqStack.pop&#xA0;calls will not exceed 10000 in a single test case.
	The total number of FreqStack.push and FreqStack.pop calls will not exceed 150000 across all test cases.



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution895
{
    public class FreqStack {​    public FreqStack() { } public void Push(int x) { } public int Pop() { } }​/** * Your FreqStack object will be instantiated and called as such: * FreqStack obj = new FreqStack(); * obj.Push(x); * int param_2 = obj.Pop(); *
}
