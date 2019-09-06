// Url:https://leetcode.com/problems/corporate-flight-bookings

/*
1109. Corporate Flight Bookings
Medium

There are n flights, and they are labeled&#xA0;from 1 to n.

We have a list of flight bookings.&#xA0; The i-th booking&#xA0;bookings[i] = [i, j, k]&#xA0;means that we booked k seats from flights labeled i to j inclusive.

Return an array answer of length n, representing the number of seats booked on each flight in order of their label.

&#xA0;
Example 1:

Input: bookings = [[1,2,10],[2,3,20],[2,5,25]], n = 5
Output: [10,55,45,25,25]


&#xA0;
Constraints:


	1 &lt;= bookings.length &lt;= 20000
	1 &lt;= bookings[i][0] &lt;= bookings[i][1] &lt;= n &lt;= 20000
	1 &lt;= bookings[i][2] &lt;= 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1109
{
    public class Solution
    {
        public void Init() { }

        public int[] CorpFlightBookings(int[][] bookings, int n) { }
    }
}
