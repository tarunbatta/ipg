// Url:https://leetcode.com/problems/swap-adjacent-in-lr-string

/*
777. Swap Adjacent in LR String
Medium

In a string composed of &apos;L&apos;, &apos;R&apos;, and &apos;X&apos; characters, like &quot;RXXLRXRXL&quot;, a move consists of either replacing one occurrence of &quot;XL&quot; with &quot;LX&quot;, or replacing one occurrence of &quot;RX&quot; with &quot;XR&quot;. Given the starting string start and the ending string end, return True if and only if there exists a sequence of moves to transform one string to the other.

Example:

Input: start = &quot;RXXLRXRXL&quot;, end = &quot;XRLXXRRLX&quot;
Output: True
Explanation:
We can transform start to end following these steps:
RXXLRXRXL -&gt;
XRXLRXRXL -&gt;
XRLXRXRXL -&gt;
XRLXXRRXL -&gt;
XRLXXRRLX


Note:


	1 &lt;= len(start) = len(end) &lt;= 10000.
	Both start and end will only consist of characters in {&apos;L&apos;, &apos;R&apos;, &apos;X&apos;}.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution777
{
    public class Solution
    {
        public void Init() { }

        public bool CanTransform(string start, string end) { }
    }
}
