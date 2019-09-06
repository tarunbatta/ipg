// Url:https://leetcode.com/problems/stamping-the-sequence

/*
936. Stamping The Sequence
Hard

You want to form a target&#xA0;string of lowercase letters.

At the beginning, your sequence is target.length&#xA0;&apos;?&apos; marks.&#xA0; You also have a stamp&#xA0;of lowercase letters.

On each turn, you may place the stamp over the sequence, and replace every letter in the sequence with the corresponding letter from the stamp.&#xA0; You can make up to 10 * target.length turns.

For example, if the initial sequence is &quot;?????&quot;, and your stamp is &quot;abc&quot;,&#xA0; then you may make &quot;abc??&quot;, &quot;?abc?&quot;, &quot;??abc&quot;&#xA0;in the first turn.&#xA0; (Note that the stamp must be fully contained in the boundaries of the sequence in order to stamp.)

If the sequence is possible to stamp, then return an array of&#xA0;the index of the left-most letter being stamped at each turn.&#xA0; If the sequence is not possible to stamp, return an empty array.

For example, if the sequence is &quot;ababc&quot;, and the stamp is &quot;abc&quot;, then we could return the answer [0, 2], corresponding to the moves &quot;?????&quot; -&gt; &quot;abc??&quot; -&gt; &quot;ababc&quot;.

Also, if the sequence is possible to stamp, it is guaranteed it is possible to stamp within 10 * target.length&#xA0;moves.&#xA0; Any answers specifying more than this number of moves&#xA0;will not be accepted.

&#xA0;

Example 1:

Input: stamp = &quot;abc&quot;, target = &quot;ababc&quot;
Output: [0,2]
([1,0,2] would also be accepted as an answer, as well as some other answers.)



Example 2:

Input: stamp = &quot;abca&quot;, target = &quot;aabcaca&quot;
Output: [3,0,1]



&#xA0;

Note:




	1 &lt;= stamp.length &lt;= target.length &lt;= 1000
	stamp and target only contain lowercase letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution936
{
    public class Solution
    {
        public void Init() { }

        public int[] MovesToStamp(string stamp, string target) { }
    }
}
