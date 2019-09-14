// Url:https://leetcode.com/problems/self-crossing

/*
335. Self Crossing
Hard

You are given an array x of n positive numbers. You start at point (0,0) and moves x[0] metres to the north, then x[1] metres to the west, x[2] metres to the south, x[3] metres to the east and so on. In other words, after each move your direction changes counter-clockwise.

Write a one-pass algorithm with O(1) extra space to determine, if your path crosses itself, or not.

 

Example 1:

&#x250C;&#x2500;&#x2500;&#x2500;&#x2510;
&#x2502;   &#x2502;
&#x2514;&#x2500;&#x2500;&#x2500;&#x253C;&#x2500;&#x2500;<
    &#x2502;

Input: [2,1,1,2]
Output: true


Example 2:

&#x250C;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2510;
&#x2502;      &#x2502;
&#x2502;
&#x2502;
&#x2514;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;&#x2500;<

Input: [1,2,3,4]
Output: false 


Example 3:

&#x250C;&#x2500;&#x2500;&#x2500;&#x2510;
&#x2502;   &#x2502;
&#x2514;&#x2500;&#x2500;&#x2500;&#x253C;<

Input: [1,1,1,1]
Output: true
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution335 {
    public class Solution {
        public void Init () {

        }

        public bool IsSelfCrossing (int[] x) {
            return false;
        }
    }
}