// Url:https://leetcode.com/problems/open-the-lock

/*
752. Open the Lock
Medium

You have a lock in front of you with 4 circular wheels.  Each wheel has 10 slots: &apos;0&apos;, &apos;1&apos;, &apos;2&apos;, &apos;3&apos;, &apos;4&apos;, &apos;5&apos;, &apos;6&apos;, &apos;7&apos;, &apos;8&apos;, &apos;9&apos;.  The wheels can rotate freely and wrap around: for example we can turn &apos;9&apos; to be &apos;0&apos;, or &apos;0&apos; to be &apos;9&apos;.  Each move consists of turning one wheel one slot.

The lock initially starts at &apos;0000&apos;, a string representing the state of the 4 wheels.

You are given a list of deadends dead ends, meaning if the lock displays any of these codes, the wheels of the lock will stop turning and you will be unable to open it.

Given a target representing the value of the wheels that will unlock the lock, return the minimum total number of turns required to open the lock, or -1 if it is impossible.


Example 1:
Input: deadends = [&quot;0201&quot;,&quot;0101&quot;,&quot;0102&quot;,&quot;1212&quot;,&quot;2002&quot;], target = &quot;0202&quot;
Output: 6
Explanation:
A sequence of valid moves would be &quot;0000&quot; -&gt; &quot;1000&quot; -&gt; &quot;1100&quot; -&gt; &quot;1200&quot; -&gt; &quot;1201&quot; -&gt; &quot;1202&quot; -&gt; &quot;0202&quot;.
Note that a sequence like &quot;0000&quot; -&gt; &quot;0001&quot; -&gt; &quot;0002&quot; -&gt; &quot;0102&quot; -&gt; &quot;0202&quot; would be invalid,
because the wheels of the lock become stuck after the display becomes the dead end &quot;0102&quot;.



Example 2:
Input: deadends = [&quot;8888&quot;], target = &quot;0009&quot;
Output: 1
Explanation:
We can turn the last wheel in reverse to move from &quot;0000&quot; -&gt; &quot;0009&quot;.



Example 3:
Input: deadends = [&quot;8887&quot;,&quot;8889&quot;,&quot;8878&quot;,&quot;8898&quot;,&quot;8788&quot;,&quot;8988&quot;,&quot;7888&quot;,&quot;9888&quot;], target = &quot;8888&quot;
Output: -1
Explanation:
We can&apos;t reach the target without getting stuck.



Example 4:
Input: deadends = [&quot;0000&quot;], target = &quot;8888&quot;
Output: -1



Note:

The length of deadends will be in the range [1, 500].
target will not be in the list deadends.
Every string in deadends and the string target will be a string of 4 digits from the 10,000 possibilities &apos;0000&apos; to &apos;9999&apos;.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution752
{
    public class Solution
    {
        public void Init() { }

        public int OpenLock(string[] deadends, string target) { }
    }
}
