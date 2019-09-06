// Url:https://leetcode.com/problems/three-equal-parts

/*
927. Three Equal Parts
Hard

Given an array A of 0s and 1s, divide the array into 3 non-empty parts such that all of these parts represent the same binary value.

If it is possible, return any [i, j]&#xA0;with i+1 &lt; j, such that:


	A[0], A[1], ..., A[i] is the first part;
	A[i+1], A[i+2], ..., A[j-1] is the second part, and
	A[j], A[j+1], ..., A[A.length - 1] is the third part.
	All three parts have equal binary value.


If it is not possible, return [-1, -1].

Note that the entire part is used when considering what binary value it represents.&#xA0; For example, [1,1,0]&#xA0;represents 6&#xA0;in decimal,&#xA0;not 3.&#xA0; Also, leading zeros are allowed, so&#xA0;[0,1,1] and [1,1] represent the same value.

&#xA0;

Example 1:

Input: [1,0,1,0,1]
Output: [0,3]



Example 2:

Input: [1,1,0,1,1]
Output: [-1,-1]


&#xA0;

Note:


	3 &lt;= A.length &lt;= 30000
	A[i] == 0&#xA0;or A[i] == 1



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution927
{
    public class Solution
    {
        public void Init() { }

        public int[] ThreeEqualParts(int[] A) { }
    }
}
