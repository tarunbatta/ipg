// Url:https://leetcode.com/problems/shortest-completing-word

/*
748. Shortest Completing Word
Easy

Find the minimum length word from a given dictionary words, which has all the letters from the string licensePlate.  Such a word is said to complete the given string licensePlate

Here, for letters we ignore case.  For example, &quot;P&quot; on the licensePlate still matches &quot;p&quot; on the word.

It is guaranteed an answer exists.  If there are multiple answers, return the one that occurs first in the array.

The license plate might have the same letter occurring multiple times.  For example, given a licensePlate of &quot;PP&quot;, the word &quot;pair&quot; does not complete the licensePlate, but the word &quot;supper&quot; does.


Example 1:
Input: licensePlate = &quot;1s3 PSt&quot;, words = [&quot;step&quot;, &quot;steps&quot;, &quot;stripe&quot;, &quot;stepple&quot;]
Output: &quot;steps&quot;
Explanation: The smallest length word that contains the letters &quot;S&quot;, &quot;P&quot;, &quot;S&quot;, and &quot;T&quot;.
Note that the answer is not &quot;step&quot;, because the letter &quot;s&quot; must occur in the word twice.
Also note that we ignored case for the purposes of comparing whether a letter exists in the word.



Example 2:
Input: licensePlate = &quot;1s3 456&quot;, words = [&quot;looks&quot;, &quot;pest&quot;, &quot;stew&quot;, &quot;show&quot;]
Output: &quot;pest&quot;
Explanation: There are 3 smallest length words that contains the letters &quot;s&quot;.
We return the one that occurred first.



Note:

licensePlate will be a string with length in range [1, 7].
licensePlate will contain digits, spaces, or letters (uppercase or lowercase).
words will have a length in the range [10, 1000].
Every words[i] will consist of lowercase letters, and have length in range [1, 15].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution748
{
    public class Solution
    {
        public string ShortestCompletingWord(string licensePlate, string[] words) { }
    }
