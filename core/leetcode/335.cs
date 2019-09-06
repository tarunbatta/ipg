// Url:https://leetcode.com/problems/self-crossing

/*
335. Self Crossing
Hard

You are given an array x of n positive numbers. You start at point (0,0) and moves x[0] metres to the north, then x[1] metres to the west, x[2] metres to the south, x[3] metres to the east and so on. In other words, after each move your direction changes counter-clockwise.

Write a one-pass algorithm with O(1) extra space to determine, if your path crosses itself, or not.

&#xA0;

Example 1:

&#x250C;&#x2500;&#x2500;&#x2500;&#x2510;
&#x2502; &#xA0; &#x2502;
&#x2514;&#x2500;&#x2500;&#x2500;&#x253C;&#x2500;&#x2500;&gt;
&#xA0; &#xA0; &#x2502;

Input: [2,1,1,2]
Output: true


Example 2:

&#x250C;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2510;
&#x2502; &#xA0; &#xA0; &#xA0;&#x2502;
&#x2502;
&#x2502;
&#x2514;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&gt;

Input: [1,2,3,4]
Output: false 


Example 3:

&#x250C;&#x2500;&#x2500;&#x2500;&#x2510;
&#x2502; &#xA0; &#x2502;
&#x2514;&#x2500;&#x2500;&#x2500;&#x253C;&gt;

Input: [1,1,1,1]
Output: true
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution335
{
    public class Solution
    {
        public void Init() { }

        public bool IsSelfCrossing(int[] x) { }
    }
}
