// Url:https://leetcode.com/problems/swap-adjacent-in-lr-string

/*
777. Swap Adjacent in LR String
Medium

In a string composed of 'L', 'R', and 'X' characters, like "RXXLRXRXL", a move consists of either replacing one occurrence of "XL" with "LX", or replacing one occurrence of "RX" with "XR". Given the starting string start and the ending string end, return True if and only if there exists a sequence of moves to transform one string to the other.

Example:

Input: start = "RXXLRXRXL", end = "XRLXXRRLX"
Output: True
Explanation:
We can transform start to end following these steps:
RXXLRXRXL ->
XRXLRXRXL ->
XRLXRXRXL ->
XRLXXRRXL ->
XRLXXRRLX


Note:


	1 <= len(start) = len(end) <= 10000.
	Both start and end will only consist of characters in {'L', 'R', 'X'}.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution777 {
    public class Solution {
        public void Init () {

        }

        public bool CanTransform (string start, string end) {
            return false;
        }
    }
}