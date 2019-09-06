// Url:https://leetcode.com/problems/number-of-music-playlists

/*
920. Number of Music Playlists
Hard

Your music player contains N&#xA0;different songs and she wants to listen to L (not necessarily different) songs during your trip. &#xA0;You&#xA0;create&#xA0;a playlist so&#xA0;that:


	Every song is played at least once
	A song can only be played again only if&#xA0;K&#xA0;other songs have been played


Return the number of possible playlists.&#xA0; As the answer can be very large, return it modulo 10^9 + 7.

&#xA0;




Example 1:

Input: N = 3, L = 3, K = 1
Output: 6
Explanation: There are 6 possible playlists. [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1].



Example 2:

Input: N = 2, L = 3, K = 0
Output: 6
Explanation: There are 6 possible playlists. [1, 1, 2], [1, 2, 1], [2, 1, 1], [2, 2, 1], [2, 1, 2], [1, 2, 2]



Example 3:

Input: N = 2, L = 3, K = 1
Output: 2
Explanation: There are 2 possible playlists. [1, 2, 1], [2, 1, 2]




&#xA0;

Note:


	0 &lt;= K &lt; N &lt;= L &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution920
{
    public class Solution
    {
        public void Init() { }

        public int NumMusicPlaylists(int N, int L, int K) { }
    }
}
