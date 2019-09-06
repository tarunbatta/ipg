// Url:https://leetcode.com/problems/card-flipping-game

/*
822. Card Flipping Game
Medium

On a table are N cards, with a positive integer printed on the front and back of each card (possibly different).

We flip any number of cards, and after we choose one&#xA0;card.&#xA0;

If the number X on the back of the chosen&#xA0;card is not on the front of any card, then this number X is good.

What is the smallest number that is good?&#xA0; If no number is good, output 0.

Here, fronts[i] and backs[i] represent the number on the front and back of card i.&#xA0;

A&#xA0;flip swaps the front and back numbers, so the value on the front is now on the back and vice versa.

Example:

Input: fronts = [1,2,4,4,7], backs = [1,3,4,1,3]
Output: 2
Explanation: If we flip the second card, the fronts are [1,3,4,4,7] and the backs are [1,2,4,1,3].
We choose the second card, which has number 2 on the back, and it isn&apos;t on the front of any card, so 2 is good.

&#xA0;

Note:


	1 &lt;= fronts.length == backs.length&#xA0;&lt;=&#xA0;1000.
	1 &lt;=&#xA0;fronts[i]&#xA0;&lt;= 2000.
	1 &lt;= backs[i]&#xA0;&lt;= 2000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution822
{
    public class Solution
    {
        public void Init() { }

        public int Flipgame(int[] fronts, int[] backs) { }
    }
}
