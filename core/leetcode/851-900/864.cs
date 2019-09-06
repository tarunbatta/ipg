// Url:https://leetcode.com/problems/shortest-path-to-get-all-keys

/*
864. Shortest Path to Get All Keys
Hard

We are given a 2-dimensional&#xA0;grid.&#xA0;&quot;.&quot; is an empty cell, &quot;#&quot; is&#xA0;a wall, &quot;@&quot; is the starting point, (&quot;a&quot;, &quot;b&quot;, ...) are keys, and (&quot;A&quot;,&#xA0;&quot;B&quot;, ...) are locks.

We start at the starting point, and one move consists of walking one space in one of the 4 cardinal directions.&#xA0; We cannot walk outside the grid, or walk into a wall.&#xA0; If we walk over a key, we pick it up.&#xA0; We can&apos;t walk over a lock unless we have the corresponding key.

For some 1 &lt;= K &lt;= 6, there is exactly one lowercase and one uppercase letter of the first K letters of the English alphabet in the grid.&#xA0; This means that there is exactly one key for each lock, and one lock for each key; and also that the letters used to represent the keys and locks were&#xA0;chosen in the same order as the English alphabet.

Return the lowest number of moves to acquire all keys.&#xA0; If&#xA0;it&apos;s impossible, return -1.

&#xA0;


Example 1:

Input: [&quot;@.a.#&quot;,&quot;###.#&quot;,&quot;b.A.B&quot;]
Output: 8



Example 2:

Input: [&quot;@..aA&quot;,&quot;..B#.&quot;,&quot;....b&quot;]
Output: 6



&#xA0;

Note:


	1 &lt;= grid.length&#xA0;&lt;= 30
	1 &lt;= grid[0].length&#xA0;&lt;= 30
	grid[i][j] contains only &apos;.&apos;, &apos;#&apos;, &apos;@&apos;,&#xA0;&apos;a&apos;-&apos;f&apos; and &apos;A&apos;-&apos;F&apos;
	The number of keys is in [1, 6].&#xA0; Each key has a different letter and opens exactly one lock.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution864
{
    public class Solution
    {
        public void Init() { }

        public int ShortestPathAllKeys(string[] grid) { }
    }
}
