// Url:https://leetcode.com/problems/student-attendance-record-ii

/*
552. Student Attendance Record II
Hard

Given a positive integer n, return the number of all possible attendance records with length n, which will be regarded as rewardable. The answer may be very large, return it after mod 109 + 7.

A student attendance record is a string that only contains the following three characters:



&apos;A&apos; : Absent. 
&apos;L&apos; : Late.
 &apos;P&apos; : Present. 




A record is regarded as rewardable if it doesn&apos;t contain more than one &apos;A&apos; (absent) or more than two continuous &apos;L&apos; (late).

Example 1:
Input: n = 2
Output: 8 
Explanation:
There are 8 records with length 2 will be regarded as rewardable:
&quot;PP&quot; , &quot;AP&quot;, &quot;PA&quot;, &quot;LP&quot;, &quot;PL&quot;, &quot;AL&quot;, &quot;LA&quot;, &quot;LL&quot;
Only &quot;AA&quot; won&apos;t be regarded as rewardable owing to more than one absent times. 



Note:
The value of n won&apos;t exceed 100,000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution552
{
    public class Solution
    {
        public void Init() { }

        public int CheckRecord(int n) { }
    }
}
