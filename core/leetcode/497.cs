// Url:https://leetcode.com/problems/random-point-in-non-overlapping-rectangles

/*
497. Random Point in Non-overlapping Rectangles
Medium

Given a list of non-overlapping&#xA0;axis-aligned rectangles rects, write a function pick which randomly and uniformily picks an integer point in the space&#xA0;covered by the rectangles.

Note:


	An integer point&#xA0;is a point that has integer coordinates.&#xA0;
	A point&#xA0;on the perimeter&#xA0;of a rectangle is&#xA0;included in the space covered by the rectangles.&#xA0;
	ith rectangle = rects[i] =&#xA0;[x1,y1,x2,y2], where [x1, y1]&#xA0;are the integer coordinates of the bottom-left corner, and [x2, y2]&#xA0;are the integer coordinates of the top-right corner.
	length and width of each rectangle does not exceed 2000.
	1 &lt;= rects.length&#xA0;&lt;= 100
	pick return a point as an array of integer coordinates&#xA0;[p_x, p_y]
	pick is called at most 10000&#xA0;times.



Example 1:

Input: 
[&quot;Solution&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;]
[[[[1,1,5,5]]],[],[],[]]
Output: 
[null,[4,1],[4,1],[3,3]]



Example 2:

Input: 
[&quot;Solution&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;,&quot;pick&quot;]
[[[[-2,-2,-1,-1],[1,0,3,0]]],[],[],[],[],[]]
Output: 
[null,[-1,-2],[2,0],[-2,-1],[3,0],[-2,-2]]



Explanation of Input Syntax:

The input is two lists:&#xA0;the subroutines called&#xA0;and their&#xA0;arguments.&#xA0;Solution&apos;s&#xA0;constructor has one argument, the array of rectangles rects. pick&#xA0;has no arguments.&#xA0;Arguments&#xA0;are&#xA0;always wrapped with a list, even if there aren&apos;t any.




&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution497
{
    public class Solution
    {
        public void Init() { }

​    public Solution(int[][] rects) { }
        public int[] Pick() { }
    }​/** * Your Solution object will be instantiated and called as such: * Solution obj = new Solution(rects); * int[] param_1 = obj.Pick(); *
}
