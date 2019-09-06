// Url:https://leetcode.com/problems/long-pressed-name

/*
925. Long Pressed Name
Easy

Your friend is typing his name&#xA0;into a keyboard.&#xA0; Sometimes, when typing a character c, the key might get long pressed, and the character will be typed 1 or more times.

You examine the typed&#xA0;characters of the keyboard.&#xA0; Return True if it is possible that it was your friends name, with some characters (possibly none) being long pressed.

&#xA0;

Example 1:

Input: name = &quot;alex&quot;, typed = &quot;aaleex&quot;
Output: true
Explanation: &apos;a&apos; and &apos;e&apos; in &apos;alex&apos; were long pressed.



Example 2:

Input: name = &quot;saeed&quot;, typed = &quot;ssaaedd&quot;
Output: false
Explanation: &apos;e&apos; must have been pressed twice, but it wasn&apos;t in the typed output.



Example 3:

Input: name = &quot;leelee&quot;, typed = &quot;lleeelee&quot;
Output: true



Example 4:

Input: name = &quot;laiden&quot;, typed = &quot;laiden&quot;
Output: true
Explanation: It&apos;s not necessary to long press any character.


&#xA0;




Note:


	name.length &lt;= 1000
	typed.length &lt;= 1000
	The characters of name and typed are lowercase letters.



&#xA0;



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution925
{
    public class Solution
    {
        public void Init() { }

        public bool IsLongPressedName(string name, string typed) { }
    }
}
