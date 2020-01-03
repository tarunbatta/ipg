// Url:https://leetcode.com/problems/group-anagrams

/*
49. Group Anagrams
Medium

Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]

Note:
	All inputs will be in lowercase.
	The order of your output does not matter.
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem49
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        // Time: O (nk)
        // Space: O (nk)
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();

            if (strs == null || strs.Length == 0)
            {
                return result;
            }

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (var item in strs)
            {
                char[] arr = item.ToCharArray();
                Array.Sort(arr);
                string key = new string(arr);

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }

                dict[key].Add(item);
            }

            return new List<IList<string>>(dict.Values);
        }
    }
}