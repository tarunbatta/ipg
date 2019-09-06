// Url:https://leetcode.com/problems/zuma-game

/*
488. Zuma Game
Hard

Think about Zuma Game. You have a row of balls on the table, colored red(R), yellow(Y), blue(B), green(G), and white(W). You also have several balls in your hand.

Each time, you may choose a ball in your hand, and insert it into the row (including the leftmost place and rightmost place). Then, if there is a group of 3 or more balls in the same color touching, remove these balls. Keep doing this until no more balls can be removed.

Find the minimal balls you have to insert to remove all the balls on the table. If you cannot remove all the balls, output -1.

Examples:
Input: &quot;WRRBBW&quot;, &quot;RB&quot;
Output: -1
Explanation: WRRBBW -&gt; WRR[R]BBW -&gt; WBBW -&gt; WBB[B]W -&gt; WW

Input: &quot;WWRRBBWW&quot;, &quot;WRBRW&quot;
Output: 2
Explanation: WWRRBBWW -&gt; WWRR[R]BBWW -&gt; WWBBWW -&gt; WWBB[B]WW -&gt; WWWW -&gt; empty

Input:&quot;G&quot;, &quot;GGGGG&quot;
Output: 2
Explanation: G -&gt; G[G] -&gt; GG[G] -&gt; empty 

Input: &quot;RBYYBBRRB&quot;, &quot;YRBGB&quot;
Output: 3
Explanation: RBYYBBRRB -&gt; RBYY[Y]BBRRB -&gt; RBBBRRB -&gt; RRRB -&gt; B -&gt; B[B] -&gt; BB[B] -&gt; empty 



Note:

You may assume that the initial row of balls on the table won&#x2019;t have any 3 or more consecutive balls with the same color.
The number of balls on the table won&apos;t exceed 20, and the string represents these balls is called &quot;board&quot; in the input.
The number of balls in your hand won&apos;t exceed 5, and the string represents these balls is called &quot;hand&quot; in the input.
Both input strings will be non-empty and only contain characters &apos;R&apos;,&apos;Y&apos;,&apos;B&apos;,&apos;G&apos;,&apos;W&apos;.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution488
{
    public class Solution
    {
        public void Init() { }

        public int FindMinStep(string board, string hand) { }
    }
}
