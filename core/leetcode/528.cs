// Url:https://leetcode.com/problems/random-pick-with-weight

/*
528. Random Pick with Weight
Medium

Given an array w of positive integers, where w[i] describes the weight of index i,&#xA0;write a function pickIndex&#xA0;which randomly&#xA0;picks an index&#xA0;in proportion&#xA0;to its weight.

Note:


	1 &lt;= w.length &lt;= 10000
	1 &lt;= w[i] &lt;= 10^5
	pickIndex&#xA0;will be called at most 10000 times.


Example 1:

Input: 
[&quot;Solution&quot;,&quot;pickIndex&quot;]
[[[1]],[]]
Output: [null,0]



Example 2:

Input: 
[&quot;Solution&quot;,&quot;pickIndex&quot;,&quot;pickIndex&quot;,&quot;pickIndex&quot;,&quot;pickIndex&quot;,&quot;pickIndex&quot;]
[[[1,3]],[],[],[],[],[]]
Output: [null,0,1,1,1,0]


Explanation of Input Syntax:

The input is two lists:&#xA0;the subroutines called&#xA0;and their&#xA0;arguments.&#xA0;Solution&apos;s&#xA0;constructor has one argument, the&#xA0;array w. pickIndex has no arguments.&#xA0;Arguments&#xA0;are&#xA0;always wrapped with a list, even if there aren&apos;t any.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution528
{
    public class Solution
    {
        public void Init() { }

​    public Solution(int[] w) { }
        public int PickIndex() { }
    }​/** * Your Solution object will be instantiated and called as such: * Solution obj = new Solution(w); * int param_1 = obj.PickIndex(); *
}
