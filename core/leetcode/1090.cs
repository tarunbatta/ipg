// Url:https://leetcode.com/problems/largest-values-from-labels

/*
1090. Largest Values From Labels
Medium

We have a set of items: the i-th item has value values[i] and label labels[i].

Then, we choose&#xA0;a subset S of these items, such that:


	|S| &lt;= num_wanted
	For every label L, the number of items in S with&#xA0;label L is &lt;= use_limit.


Return the largest possible sum of the subset S.

&#xA0;


Example 1:

Input: values = [5,4,3,2,1], labels = [1,1,2,2,3], num_wanted = 3, use_limit = 1
Output: 9
Explanation: The subset chosen is the first, third, and fifth item.



Example 2:

Input: values = [5,4,3,2,1], labels = [1,3,3,3,2], num_wanted = 3, use_limit = 2
Output: 12
Explanation: The subset chosen is the first, second, and third item.



Example 3:

Input: values = [9,8,8,7,6], labels = [0,0,0,1,1], num_wanted = 3, use_limit = 1
Output:&#xA0;16
Explanation: The subset chosen is the first and fourth item.



Example 4:

Input: values = [9,8,8,7,6], labels = [0,0,0,1,1], num_wanted = 3, use_limit = 2
Output: 24
Explanation: The subset chosen is the first, second, and fourth item.


&#xA0;

Note:


	1 &lt;= values.length == labels.length &lt;= 20000
	0 &lt;= values[i], labels[i]&#xA0;&lt;= 20000
	1 &lt;= num_wanted, use_limit&#xA0;&lt;= values.length
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1090
{
    public class Solution
    {
        public void Init() { }

        public int LargestValsFromLabels(int[] values, int[] labels, int num_wanted, int use_limit) { }
    }
}
