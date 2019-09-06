// Url:https://leetcode.com/problems/dinner-plate-stacks

/*
1172. Dinner Plate Stacks
Hard

You have an infinite number of stacks arranged in a row and numbered (left to right) from 0, each of the stacks has the same&#xA0;maximum capacity.

Implement the DinnerPlates class:


	DinnerPlates(int capacity) Initializes the object with the maximum capacity of the stacks.
	void push(int val)&#xA0;pushes the given positive integer val into the leftmost stack with size less than capacity.
	int pop()&#xA0;returns the value at the top of the rightmost non-empty stack and removes it from that stack, and returns -1 if all stacks are empty.
	int popAtStack(int index)&#xA0;returns the value at the top of the stack with the given index and removes it from that stack, and returns -1 if the stack with that&#xA0;given index is empty.


Example:

Input: 
[&quot;DinnerPlates&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;push&quot;,&quot;popAtStack&quot;,&quot;push&quot;,&quot;push&quot;,&quot;popAtStack&quot;,&quot;popAtStack&quot;,&quot;pop&quot;,&quot;pop&quot;,&quot;pop&quot;,&quot;pop&quot;,&quot;pop&quot;]
[[2],[1],[2],[3],[4],[5],[0],[20],[21],[0],[2],[],[],[],[],[]]
Output: 
[null,null,null,null,null,null,2,null,null,20,21,5,4,3,1,-1]

Explanation: 
DinnerPlates D = DinnerPlates(2);  // Initialize with capacity = 2
D.push(1);
D.push(2);
D.push(3);
D.push(4);
D.push(5);         // The stacks are now:  2 &#xA0;4
&#xA0;                                          1 &#xA0;3 &#xA0;5
                                           &#xFE48; &#xFE48; &#xFE48;
D.popAtStack(0);   // Returns 2.  The stacks are now:    &#xA0;4
            &#xA0;                                          1 &#xA0;3 &#xA0;5
                                                       &#xFE48; &#xFE48; &#xFE48;
D.push(20);        // The stacks are now: 20  4
&#xA0;                                          1 &#xA0;3 &#xA0;5
                                           &#xFE48; &#xFE48; &#xFE48;
D.push(21);        // The stacks are now: 20  4 21
&#xA0;                                          1 &#xA0;3 &#xA0;5
                                           &#xFE48; &#xFE48; &#xFE48;
D.popAtStack(0);   // Returns 20.  The stacks are now:     4 21
             &#xA0;                                          1 &#xA0;3 &#xA0;5
                                                        &#xFE48; &#xFE48; &#xFE48;
D.popAtStack(2);   // Returns 21.  The stacks are now:     4
             &#xA0;                                          1 &#xA0;3 &#xA0;5
                                                        &#xFE48; &#xFE48; &#xFE48; 
D.pop()            // Returns 5.  The stacks are now:      4
             &#xA0;                                          1 &#xA0;3 
                                                        &#xFE48; &#xFE48;  
D.pop()            // Returns 4.  The stacks are now:   1 &#xA0;3 
                                                        &#xFE48; &#xFE48;   
D.pop()            // Returns 3.  The stacks are now:   1 
                                                        &#xFE48;   
D.pop()            // Returns 1.  There are no stacks.
D.pop()            // Returns -1.  There are still no stacks.


&#xA0;
Constraints:


	1 &lt;= capacity&#xA0;&lt;= 20000
	1 &lt;= val&#xA0;&lt;= 20000
	0 &lt;= index&#xA0;&lt;= 100000
	At most 200000&#xA0;calls will be made to push, pop, and popAtStack.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1172
{
    public class DinnerPlates
    {​
     public DinnerPlates(int capacity)
        { }

        public void Push(int val) { }

        public int Pop() { }

        public int PopAtStack(int index) { }

    }​
    /** * Your DinnerPlates object will be instantiated and called as such: * DinnerPlates obj = new DinnerPlates(capacity); * obj.Push(val); * int param_2 = obj.Pop(); * int param_3 = obj.PopAtStack(index); * */
}
