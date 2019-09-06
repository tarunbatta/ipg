// Url:https://leetcode.com/problems/alphabet-board-path

/*
1138. Alphabet Board Path
Medium

On an alphabet board, we start at position (0, 0), corresponding to character&#xA0;board[0][0].

Here, board = [&quot;abcde&quot;, &quot;fghij&quot;, &quot;klmno&quot;, &quot;pqrst&quot;, &quot;uvwxy&quot;, &quot;z&quot;], as shown in the diagram below.



We may make the following moves:


	&apos;U&apos; moves our position up one row, if the position exists on the board;
	&apos;D&apos; moves our position down one row, if the position exists on the board;
	&apos;L&apos; moves our position left one column, if the position exists on the board;
	&apos;R&apos; moves our position right one column, if the position exists on the board;
	&apos;!&apos;&#xA0;adds the character board[r][c] at our current position (r, c)&#xA0;to the&#xA0;answer.


(Here, the only positions that exist on the board are positions with letters on them.)

Return a sequence of moves that makes our answer equal to target&#xA0;in the minimum number of moves.&#xA0; You may return any path that does so.

&#xA0;
Example 1:
Input: target = &quot;leet&quot;
Output: &quot;DDR!UURRR!!DDD!&quot;
Example 2:
Input: target = &quot;code&quot;
Output: &quot;RR!DDRR!UUL!R!&quot;

&#xA0;
Constraints:


	1 &lt;= target.length &lt;= 100
	target consists only of English lowercase letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1138
{
    public class Solution
    {
        public void Init() { }

        public string AlphabetBoardPath(string target) { }
    }
}
