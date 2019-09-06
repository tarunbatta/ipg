// Url:https://leetcode.com/problems/super-egg-drop

/*
887. Super Egg Drop
Hard

You are given K eggs, and you have access to a building with N floors from 1 to N.&#xA0;

Each egg is identical in function, and if an egg breaks, you cannot drop it&#xA0;again.

You know that there exists a floor F with 0 &lt;= F &lt;= N such that any egg dropped at a floor higher than F will break, and any egg dropped at or below floor F will not break.

Each move, you may take an egg (if you have an unbroken one) and drop it from any floor X (with&#xA0;1 &lt;= X &lt;= N).&#xA0;

Your goal is to know&#xA0;with certainty&#xA0;what the value of F is.

What is the minimum number of moves that you need to know with certainty&#xA0;what F is, regardless of the initial value of F?

&#xA0;





Example 1:

Input: K = 1, N = 2
Output: 2
Explanation: 
Drop the egg from floor 1.  If it breaks, we know with certainty that F = 0.
Otherwise, drop the egg from floor 2.  If it breaks, we know with certainty that F = 1.
If it didn&apos;t break, then we know with certainty F = 2.
Hence, we needed 2 moves in the worst case to know what F is with certainty.



Example 2:

Input: K = 2, N = 6
Output: 3



Example 3:

Input: K = 3, N = 14
Output: 4


&#xA0;

Note:


	1 &lt;= K &lt;= 100
	1 &lt;= N &lt;= 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution887
{
    public class Solution
    {
        public void Init() { }

        public int SuperEggDrop(int K, int N) { }
    }
}
