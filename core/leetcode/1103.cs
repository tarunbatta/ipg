// Url:https://leetcode.com/problems/distribute-candies-to-people

/*
1103. Distribute Candies to People
Easy

We distribute some&#xA0;number of candies, to a row of n =&#xA0;num_people&#xA0;people in the following way:

We then give 1 candy to the first person, 2 candies to the second person, and so on until we give n&#xA0;candies to the last person.

Then, we go back to the start of the row, giving n&#xA0;+ 1 candies to the first person, n&#xA0;+ 2 candies to the second person, and so on until we give 2 * n&#xA0;candies to the last person.

This process repeats (with us giving one more candy each time, and moving to the start of the row after we reach the end) until we run out of candies.&#xA0; The last person will receive all of our remaining candies (not necessarily one more than the previous gift).

Return an array (of length num_people&#xA0;and sum candies) that represents the final distribution of candies.

&#xA0;
Example 1:

Input: candies = 7, num_people = 4
Output: [1,2,3,1]
Explanation:
On the first turn, ans[0] += 1, and the array is [1,0,0,0].
On the second turn, ans[1] += 2, and the array is [1,2,0,0].
On the third turn, ans[2] += 3, and the array is [1,2,3,0].
On the fourth turn, ans[3] += 1 (because there is only one candy left), and the final array is [1,2,3,1].


Example 2:

Input: candies = 10, num_people = 3
Output: [5,2,3]
Explanation: 
On the first turn, ans[0] += 1, and the array is [1,0,0].
On the second turn, ans[1] += 2, and the array is [1,2,0].
On the third turn, ans[2] += 3, and the array is [1,2,3].
On the fourth turn, ans[0] += 4, and the final array is [5,2,3].


&#xA0;
Constraints:


	1 &lt;= candies &lt;= 10^9
	1 &lt;= num_people &lt;= 1000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1103
{
    public class Solution
    {
        public void Init() { }

        public int[] DistributeCandies(int candies, int num_people) { }
    }
}
