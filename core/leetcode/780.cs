// Url:https://leetcode.com/problems/reaching-points

/*
780. Reaching Points
Hard

A move consists of taking a point (x, y) and transforming it to either (x, x+y) or (x+y, y).

Given a starting point (sx, sy) and a target point (tx, ty), return True if and only if a sequence of moves exists to transform the point (sx, sy) to (tx, ty). Otherwise, return False.

Examples:
Input: sx = 1, sy = 1, tx = 3, ty = 5
Output: True
Explanation:
One series of moves that transforms the starting point to the target is:
(1, 1) -> (1, 2)
(1, 2) -> (3, 2)
(3, 2) -> (3, 5)

Input: sx = 1, sy = 1, tx = 2, ty = 2
Output: False

Input: sx = 1, sy = 1, tx = 1, ty = 1
Output: True



Note:


	sx, sy, tx, ty will all be integers in the range [1, 10^9].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem780
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        public bool ReachingPoints(int sx, int sy, int tx, int ty)
        {
            return false;
        }
    }
}