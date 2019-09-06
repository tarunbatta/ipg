// Url:https://leetcode.com/problems/minimum-index-sum-of-two-lists

/*
599. Minimum Index Sum of Two Lists
Easy

Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings. 


You need to help them find out their common interest with the least list index sum. If there is a choice tie between answers, output all of them with no order requirement. You could assume there always exists an answer.



Example 1:
Input:
[&quot;Shogun&quot;, &quot;Tapioca Express&quot;, &quot;Burger King&quot;, &quot;KFC&quot;]
[&quot;Piatti&quot;, &quot;The Grill at Torrey Pines&quot;, &quot;Hungry Hunter Steakhouse&quot;, &quot;Shogun&quot;]
Output: [&quot;Shogun&quot;]
Explanation: The only restaurant they both like is &quot;Shogun&quot;.



Example 2:
Input:
[&quot;Shogun&quot;, &quot;Tapioca Express&quot;, &quot;Burger King&quot;, &quot;KFC&quot;]
[&quot;KFC&quot;, &quot;Shogun&quot;, &quot;Burger King&quot;]
Output: [&quot;Shogun&quot;]
Explanation: The restaurant they both like and have the least index sum is &quot;Shogun&quot; with index sum 1 (0+1).




Note:

The length of both lists will be in the range of [1, 1000].
The length of strings in both lists will be in the range of [1, 30].
The index is starting from 0 to the list length minus 1.
No duplicates in both lists.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution599
{
    public class Solution
    {
        public void Init() { }

        public string[] FindRestaurant(string[] list1, string[] list2) { }
    }
}
