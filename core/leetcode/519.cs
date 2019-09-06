// Url:https://leetcode.com/problems/random-flip-matrix

/*
519. Random Flip Matrix
Medium

You are given the number of rows n_rows&#xA0;and number of columns n_cols&#xA0;of a&#xA0;2D&#xA0;binary matrix&#xA0;where all values are initially 0.&#xA0;Write a function flip&#xA0;which chooses&#xA0;a 0 value&#xA0;uniformly at random,&#xA0;changes it to 1,&#xA0;and then returns the position [row.id, col.id] of that value. Also, write a function reset which sets all values back to 0.&#xA0;Try to minimize the number of calls to system&apos;s Math.random() and optimize the time and&#xA0;space complexity.

Note:


	1 &lt;= n_rows, n_cols&#xA0;&lt;= 10000
	0 &lt;= row.id &lt; n_rows and 0 &lt;= col.id &lt; n_cols
	flip&#xA0;will not be called when the matrix has no&#xA0;0 values left.
	the total number of calls to&#xA0;flip&#xA0;and reset&#xA0;will not exceed&#xA0;1000.


Example 1:

Input: 
[&quot;Solution&quot;,&quot;flip&quot;,&quot;flip&quot;,&quot;flip&quot;,&quot;flip&quot;]
[[2,3],[],[],[],[]]
Output: [null,[0,1],[1,2],[1,0],[1,1]]



Example 2:

Input: 
[&quot;Solution&quot;,&quot;flip&quot;,&quot;flip&quot;,&quot;reset&quot;,&quot;flip&quot;]
[[1,2],[],[],[],[]]
Output: [null,[0,0],[0,1],null,[0,0]]


Explanation of Input Syntax:

The input is two lists:&#xA0;the subroutines called&#xA0;and their&#xA0;arguments. Solution&apos;s constructor&#xA0;has two arguments, n_rows and n_cols.&#xA0;flip&#xA0;and reset have&#xA0;no&#xA0;arguments.&#xA0;Arguments&#xA0;are&#xA0;always wrapped with a list, even if there aren&apos;t any.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution519
{
    public class Solution
    {
        public void Init() { }

​    public Solution(int n_rows, int n_cols) { }
        public int[] Flip() { }
        public void Reset() { }
    }​/** * Your Solution object will be instantiated and called as such: * Solution obj = new Solution(n_rows, n_cols); * int[] param_1 = obj.Flip(); * obj.Reset(); *
}
