// Url:https://leetcode.com/problems/image-overlap

/*
835. Image Overlap
Medium

Two images A and B are given, represented as&#xA0;binary, square matrices of the same size.&#xA0; (A binary matrix has only 0s and 1s as values.)

We translate one image however we choose (sliding it left, right, up, or down any number of units), and place it on top of the other image.&#xA0; After, the overlap of this translation is the number of positions that have a 1 in both images.

(Note also that a translation does not include any kind of rotation.)

What is the largest possible overlap?

Example 1:

Input: A = [[1,1,0],
            [0,1,0],
&#xA0;           [0,1,0]]
&#xA0;      B = [[0,0,0],
&#xA0;           [0,1,1],
&#xA0;           [0,0,1]]
Output: 3
Explanation: We slide A to right by 1 unit and down by 1 unit.

Notes:&#xA0;


	1 &lt;= A.length = A[0].length = B.length = B[0].length &lt;= 30
	0 &lt;=&#xA0;A[i][j], B[i][j] &lt;= 1
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution835
{
    public class Solution
    {
        public void Init() { }

        public int LargestOverlap(int[][] A, int[][] B) { }
    }
}
