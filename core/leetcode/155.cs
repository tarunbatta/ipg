// Url:https://leetcode.com/problems/min-stack

/*
155. Min Stack
Easy

Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.


	push(x) -- Push element x onto stack.
	pop() -- Removes the element on top of the stack.
	top() -- Get the top element.
	getMin() -- Retrieve the minimum element in the stack.


 

Example:

MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.


 
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem155 {
    public class Solution {
        public void Init () {
            MinStack obj = new MinStack ();
            obj.Push (1);
            obj.Pop ();
            int param_3 = obj.Top ();
            int param_4 = obj.GetMin ();
        }
    }

    public class MinStack {
        public MinStack () {

        }

        public void Push (int x) {

        }

        public void Pop () {

        }

        public int Top () {
            return 0;
        }

        public int GetMin () {
            return 0;
        }
    }
}