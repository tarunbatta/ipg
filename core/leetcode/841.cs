// Url:https://leetcode.com/problems/keys-and-rooms

/*
841. Keys and Rooms
Medium

There are N rooms and you start in room 0.&#xA0; Each room has a distinct number in 0, 1, 2, ..., N-1, and each room may have&#xA0;some keys to access the next room.&#xA0;

Formally, each room i&#xA0;has a list of keys rooms[i], and each key rooms[i][j] is an integer in [0, 1, ..., N-1] where N = rooms.length.&#xA0; A key rooms[i][j] = v&#xA0;opens the room with number v.

Initially, all the rooms start locked (except for room 0).&#xA0;

You can walk back and forth between rooms freely.

Return true&#xA0;if and only if you can enter&#xA0;every room.




Example 1:

Input: [[1],[2],[3],[]]
Output: true
Explanation:  
We start in room 0, and pick up key 1.
We then go to room 1, and pick up key 2.
We then go to room 2, and pick up key 3.
We then go to room 3.  Since we were able to go to every room, we return true.


Example 2:

Input: [[1,3],[3,0,1],[2],[0]]
Output: false
Explanation: We can&apos;t enter the room with number 2.


Note:


	1 &lt;= rooms.length &lt;=&#xA0;1000
	0 &lt;= rooms[i].length &lt;= 1000
	The number of keys in all rooms combined is at most&#xA0;3000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution841
{
    public class Solution
    {
        public void Init() { }

        public bool CanVisitAllRooms(IList<IList<int>> rooms) { }
    }
}
