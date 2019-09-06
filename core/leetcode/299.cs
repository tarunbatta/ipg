// Url:https://leetcode.com/problems/bulls-and-cows

/*
299. Bulls and Cows
Easy

You are playing the following Bulls and Cows game with your friend: You write down a number and ask your friend to guess what the number is. Each time your friend makes a guess, you provide a hint that indicates how many digits in said guess match your secret number exactly in both digit and position (called &quot;bulls&quot;) and how many digits match the secret number but locate in the wrong position (called &quot;cows&quot;). Your friend will use successive guesses and hints to eventually derive the secret number.

Write a function to return a hint according to the secret number and friend&apos;s guess, use A to indicate the bulls and B to indicate the cows.&#xA0;

Please note that both secret number and friend&apos;s guess may contain duplicate digits.

Example 1:

Input: secret = &quot;1807&quot;, guess = &quot;7810&quot;

Output: &quot;1A3B&quot;

Explanation: 1 bull and 3 cows. The bull is 8, the cows are 0, 1 and 7.

Example 2:

Input: secret = &quot;1123&quot;, guess = &quot;0111&quot;

Output: &quot;1A1B&quot;

Explanation: The 1st 1 in friend&apos;s guess is a bull, the 2nd or 3rd 1 is a cow.

Note: You may assume that the secret number and your friend&apos;s guess only contain digits, and their lengths are always equal.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution299
{
    public class Solution
    {
        public void Init() { }

        public string GetHint(string secret, string guess) { }
    }
}
