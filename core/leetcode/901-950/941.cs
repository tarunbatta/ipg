// Url:https://leetcode.com/problems/valid-mountain-array

/*
941. Valid Mountain Array
Easy

Given an array A of integers, return true if and only if it is a valid mountain array.

Recall that A is a mountain array if and only if:


	A.length &gt;= 3
	There exists some i with&#xA0;0 &lt; i&#xA0;&lt; A.length - 1&#xA0;such that:
	
		A[0] &lt; A[1] &lt; ... A[i-1] &lt; A[i] 
		A[i] &gt; A[i+1] &gt; ... &gt; A[A.length - 1]
	
	


&#xA0;

Example 1:

Input: [2,1]
Output: false



Example 2:

Input: [3,5,5]
Output: false



Example 3:

Input: [0,3,2,1]
Output: true



&#xA0;

Note:


	0 &lt;= A.length &lt;= 10000
	0 &lt;= A[i] &lt;= 10000&#xA0;



&#xA0;


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution941
{
    public class Solution
    {
        public void Init() { }

        public bool ValidMountainArray(int[] A) { }
    }
}
