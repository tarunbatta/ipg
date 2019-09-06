// Url:https://leetcode.com/problems/min-stack

/*
155. Min Stack
Easy

Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.


	push(x) -- Push element x onto stack.
	pop() -- Removes the element on top of the stack.
	top() -- Get the top element.
	getMin() -- Retrieve the minimum element in the stack.


&#xA0;

Example:

MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --&gt; Returns -3.
minStack.pop();
minStack.top();      --&gt; Returns 0.
minStack.getMin();   --&gt; Returns -2.


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution155
{
    public class MinStack {​    /** initialize your data structure here. */    public MinStack() { } public void Push(int x) { } public void Pop() { } public int Top() { } public int GetMin() { } }​/** * Your MinStack object will be instantiated and called as such: * MinStack obj = new MinStack(); * obj.Push(x); * obj.Pop(); * int param_3 = obj.Top(); * int param_4 = obj.GetMin(); *
}
