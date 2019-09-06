// Url:https://leetcode.com/problems/remove-boxes

/*
546. Remove Boxes
Hard

Given several boxes with different colors represented by different positive numbers. 
You may experience several rounds to remove boxes until there is no box left. Each time you can choose some continuous boxes with the same color (composed of k boxes, k &gt;= 1), remove them and get k*k points.
Find the maximum points you can get.


Example 1:
Input: 
[1, 3, 2, 2, 2, 3, 4, 3, 1]

Output:
23

Explanation: 
[1, 3, 2, 2, 2, 3, 4, 3, 1] 
----&gt; [1, 3, 3, 4, 3, 1] (3*3=9 points) 
----&gt; [1, 3, 3, 3, 1] (1*1=1 points) 
----&gt; [1, 1] (3*3=9 points) 
----&gt; [] (2*2=4 points)



Note:
The number of boxes n would not exceed 100.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution546
{
    public class Solution
    {
        public void Init() { }

        public int RemoveBoxes(int[] boxes) { }
    }
}
