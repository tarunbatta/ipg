// Url:https://leetcode.com/problems/guess-the-word

/*
843. Guess the Word
Hard

This problem is an&#xA0;interactive problem&#xA0;new to the LeetCode platform.

We are given a word list of unique words, each word is 6 letters long, and one word in this list is chosen as secret.

You may call master.guess(word)&#xA0;to guess a word.&#xA0; The guessed word should have&#xA0;type string&#xA0;and must be from the original list&#xA0;with 6 lowercase letters.

This function returns an&#xA0;integer&#xA0;type, representing&#xA0;the number of exact matches (value and position) of your guess to the secret word.&#xA0; Also, if your guess is not in the given wordlist, it will return -1 instead.

For each test case, you have 10 guesses to guess the word. At the end of any number of calls, if you have made 10 or less calls to master.guess&#xA0;and at least one of these guesses was the secret, you pass the testcase.

Besides the example test case below, there will be 5&#xA0;additional test cases, each with 100 words in the word list.&#xA0; The letters of each word in those testcases were chosen&#xA0;independently at random from &apos;a&apos; to &apos;z&apos;, such that every word in the given word lists is unique.

Example 1:
Input:&#xA0;secret = &quot;acckzz&quot;, wordlist = [&quot;acckzz&quot;,&quot;ccbazz&quot;,&quot;eiowzz&quot;,&quot;abcczz&quot;]

Explanation:

master.guess(&quot;aaaaaa&quot;) returns -1, because&#xA0;&quot;aaaaaa&quot;&#xA0;is not in wordlist.
master.guess(&quot;acckzz&quot;) returns 6, because&#xA0;&quot;acckzz&quot; is secret and has all 6&#xA0;matches.
master.guess(&quot;ccbazz&quot;) returns 3, because&#xA0;&quot;ccbazz&quot;&#xA0;has 3 matches.
master.guess(&quot;eiowzz&quot;) returns 2, because&#xA0;&quot;eiowzz&quot;&#xA0;has 2&#xA0;matches.
master.guess(&quot;abcczz&quot;) returns 4, because&#xA0;&quot;abcczz&quot; has 4 matches.

We made 5 calls to&#xA0;master.guess and one of them was the secret, so we pass the test case.


Note:&#xA0; Any solutions that attempt to circumvent the judge&#xA0;will result in disqualification.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution843
{
    /** * // This is the Master's API interface. * // You should not implement it, or speculate about its implementation * class Master { *     public int Guess(string word); * } */
    class Solution
    {
        public void FindSecretWord(string[] wordlist, Master master) { }
    }
