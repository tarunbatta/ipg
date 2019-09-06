// Url:https://leetcode.com/problems/number-of-valid-words-for-each-puzzle

/*
1178. Number of Valid Words for Each Puzzle
Hard

With respect to a given puzzle string, a word is valid&#xA0;if both the following conditions are satisfied:

	word contains the first letter of puzzle.
	For each letter in word, that letter is in puzzle.
	For example, if the puzzle is &quot;abcdefg&quot;, then valid words are &quot;faced&quot;, &quot;cabbage&quot;, and &quot;baggage&quot;; while invalid words are &quot;beefed&quot; (doesn&apos;t include &quot;a&quot;) and &quot;based&quot; (includes &quot;s&quot; which isn&apos;t in the puzzle).

Return an array answer, where answer[i] is the number of words in the given word list&#xA0;words that are valid with respect to the puzzle puzzles[i].
&#xA0;
Example :

Input: 
words = [&quot;aaaa&quot;,&quot;asas&quot;,&quot;able&quot;,&quot;ability&quot;,&quot;actt&quot;,&quot;actor&quot;,&quot;access&quot;], 
puzzles = [&quot;aboveyz&quot;,&quot;abrodyz&quot;,&quot;abslute&quot;,&quot;absoryz&quot;,&quot;actresz&quot;,&quot;gaswxyz&quot;]
Output: [1,1,3,2,4,0]
Explanation:
1 valid word&#xA0;for &quot;aboveyz&quot; : &quot;aaaa&quot; 
1 valid word&#xA0;for &quot;abrodyz&quot; : &quot;aaaa&quot;
3 valid words for &quot;abslute&quot; : &quot;aaaa&quot;, &quot;asas&quot;, &quot;able&quot;
2 valid words for&#xA0;&quot;absoryz&quot; : &quot;aaaa&quot;, &quot;asas&quot;
4 valid words for&#xA0;&quot;actresz&quot; : &quot;aaaa&quot;, &quot;asas&quot;, &quot;actt&quot;, &quot;access&quot;
There&apos;re&#xA0;no valid words for&#xA0;&quot;gaswxyz&quot; cause none of the words in the list contains letter &apos;g&apos;.


&#xA0;
Constraints:


	1 &lt;= words.length &lt;= 10^5
	4 &lt;= words[i].length &lt;= 50
	1 &lt;= puzzles.length &lt;= 10^4
	puzzles[i].length == 7
	words[i][j], puzzles[i][j] are English lowercase letters.
	Each puzzles[i] doesn&apos;t contain repeated characters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1178
{
    public class Solution
    {
        public void Init() { }

        public IList<int> FindNumOfValidWords(string[] words, string[] puzzles) { }
    }
}
