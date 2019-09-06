// Url:https://leetcode.com/problems/regions-cut-by-slashes

/*
959. Regions Cut By Slashes
Medium

In a N x N&#xA0;grid composed of 1 x 1 squares, each 1 x 1 square consists of a /, \, or blank space.&#xA0; These characters divide the square into contiguous regions.

(Note that backslash characters are escaped, so a \&#xA0;is represented as &quot;\\&quot;.)

Return the number of regions.

&#xA0;















Example 1:

Input:
[
&#xA0; &quot; /&quot;,
&#xA0; &quot;/ &quot;
]
Output: 2
Explanation: The 2x2 grid is as follows:




Example 2:

Input:
[
&#xA0; &quot; /&quot;,
&#xA0; &quot;  &quot;
]
Output: 1
Explanation: The 2x2 grid is as follows:




Example 3:

Input:
[
&#xA0; &quot;\\/&quot;,
&#xA0; &quot;/\\&quot;
]
Output: 4
Explanation: (Recall that because \ characters are escaped, &quot;\\/&quot; refers to \/, and &quot;/\\&quot; refers to /\.)
The 2x2 grid is as follows:




Example 4:

Input:
[
&#xA0; &quot;/\\&quot;,
&#xA0; &quot;\\/&quot;
]
Output: 5
Explanation: (Recall that because \ characters are escaped, &quot;/\\&quot; refers to /\, and &quot;\\/&quot; refers to \/.)
The 2x2 grid is as follows:




Example 5:

Input:
[
&#xA0; &quot;//&quot;,
&#xA0; &quot;/ &quot;
]
Output: 3
Explanation: The 2x2 grid is as follows:



&#xA0;

Note:


	1 &lt;= grid.length == grid[0].length &lt;= 30
	grid[i][j] is either &apos;/&apos;, &apos;\&apos;, or &apos; &apos;.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution959
{
    public class Solution
    {
        public void Init() { }

        public int RegionsBySlashes(string[] grid) { }
    }
}
