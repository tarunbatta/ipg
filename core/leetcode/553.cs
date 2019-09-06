// Url:https://leetcode.com/problems/optimal-division

/*
553. Optimal Division
Medium

Given a list of positive integers, the adjacent integers will perform the float division. For example, [2,3,4] -&gt; 2 / 3 / 4.

However, you can add any number of parenthesis at any position to change the priority of operations. You should find out how to add parenthesis to get the maximum result, and return the corresponding expression in string format. Your expression should NOT contain redundant parenthesis.

Example:
Input: [1000,100,10,2]
Output: &quot;1000/(100/10/2)&quot;
Explanation:
1000/(100/10/2) = 1000/((100/10)/2) = 200
However, the bold parenthesis in &quot;1000/((100/10)/2)&quot; are redundant, since they don&apos;t influence the operation priority. So you should return &quot;1000/(100/10/2)&quot;. 

Other cases:
1000/(100/10)/2 = 50
1000/(100/(10/2)) = 50
1000/100/10/2 = 0.5
1000/100/(10/2) = 2



Note:

The length of the input array is [1, 10].
Elements in the given array will be in range [2, 1000].
There is only one optimal division for each test case.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution553
{
    public class Solution
    {
        public void Init() { }

        public string OptimalDivision(int[] nums) { }
    }
}
