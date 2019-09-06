// Url:https://leetcode.com/problems/baseball-game

/*
682. Baseball Game
Easy

You&apos;re now a baseball game point recorder.



Given a list of strings, each string can be one of the 4 following types:

Integer (one round&apos;s score): Directly represents the number of points you get in this round.
&quot;+&quot; (one round&apos;s score): Represents that the points you get in this round are the sum of the last two valid round&apos;s points.
&quot;D&quot; (one round&apos;s score): Represents that the points you get in this round are the doubled data of the last valid round&apos;s points.
&quot;C&quot; (an operation, which isn&apos;t a round&apos;s score): Represents the last valid round&apos;s points you get were invalid and should be removed.




Each round&apos;s operation is permanent and could have an impact on the round before and the round after.



You need to return the sum of the points you could get in all the rounds.


Example 1:
Input: [&quot;5&quot;,&quot;2&quot;,&quot;C&quot;,&quot;D&quot;,&quot;+&quot;]
Output: 30
Explanation: 
Round 1: You could get 5 points. The sum is: 5.
Round 2: You could get 2 points. The sum is: 7.
Operation 1: The round 2&apos;s data was invalid. The sum is: 5.  
Round 3: You could get 10 points (the round 2&apos;s data has been removed). The sum is: 15.
Round 4: You could get 5 + 10 = 15 points. The sum is: 30.



Example 2:
Input: [&quot;5&quot;,&quot;-2&quot;,&quot;4&quot;,&quot;C&quot;,&quot;D&quot;,&quot;9&quot;,&quot;+&quot;,&quot;+&quot;]
Output: 27
Explanation: 
Round 1: You could get 5 points. The sum is: 5.
Round 2: You could get -2 points. The sum is: 3.
Round 3: You could get 4 points. The sum is: 7.
Operation 1: The round 3&apos;s data is invalid. The sum is: 3.  
Round 4: You could get -4 points (the round 3&apos;s data has been removed). The sum is: -1.
Round 5: You could get 9 points. The sum is: 8.
Round 6: You could get -4 + 9 = 5 points. The sum is 13.
Round 7: You could get 9 + 5 = 14 points. The sum is 27.



Note:
The size of the input list will be between 1 and 1000.
Every integer represented in the list will be between -30000 and 30000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution682
{
    public class Solution
    {
        public void Init() { }

        public int CalPoints(string[] ops) { }
    }
}
