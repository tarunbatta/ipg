// Url:https://leetcode.com/problems/friends-of-appropriate-ages

/*
825. Friends Of Appropriate Ages
Medium

Some people will make friend requests. The&#xA0;list of their ages is given and&#xA0;ages[i]&#xA0;is the age of the&#xA0;ith person.&#xA0;

Person A will NOT friend request person B (B != A) if any of the following conditions are true:


	age[B]&#xA0;&lt;= 0.5 * age[A]&#xA0;+ 7
	age[B]&#xA0;&gt; age[A]
	age[B]&#xA0;&gt; 100 &amp;&amp;&#xA0;age[A]&#xA0;&lt; 100


Otherwise, A will friend request B.

Note that if&#xA0;A requests B, B does not necessarily request A.&#xA0; Also, people will not friend request themselves.

How many total friend requests are made?

Example 1:

Input: [16,16]
Output: 2
Explanation: 2 people friend request each other.


Example 2:

Input: [16,17,18]
Output: 2
Explanation: Friend requests are made 17 -&gt; 16, 18 -&gt; 17.

Example 3:

Input: [20,30,100,110,120]
Output: 
Explanation: Friend requests are made 110 -&gt; 100, 120 -&gt; 110, 120 -&gt; 100.


&#xA0;

Notes:


	1 &lt;= ages.length&#xA0;&lt;= 20000.
	1 &lt;= ages[i] &lt;= 120.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution825
{
    public class Solution
    {
        public void Init() { }

        public int NumFriendRequests(int[] ages) { }
    }
}
