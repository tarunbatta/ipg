// Url:https://leetcode.com/problems/compare-version-numbers

/*
165. Compare Version Numbers
Medium

Compare two version numbers version1 and version2.
If version1 &gt; version2 return 1;&#xA0;if version1 &lt; version2 return -1;otherwise return 0.

You may assume that the version strings are non-empty and contain only digits and the . character.
The . character does not represent a decimal point and is used to separate number sequences.
For instance, 2.5 is not &quot;two and a half&quot; or &quot;half way to version three&quot;, it is the fifth second-level revision of the second first-level revision.
You may assume the default revision number for each level of a version number to be 0. For example, version number 3.4 has a revision number of 3 and 4 for its first and second level revision number. Its third and fourth level revision number are both 0.

&#xA0;

Example 1:
Input: version1 = &quot;0.1&quot;, version2 = &quot;1.1&quot;
Output: -1

Example 2:
Input: version1 = &quot;1.0.1&quot;, version2 = &quot;1&quot;
Output: 1

Example 3:
Input: version1 = &quot;7.5.2.4&quot;, version2 = &quot;7.5.3&quot;
Output: -1

Example 4:
Input: version1 = &quot;1.01&quot;, version2 = &quot;1.001&quot;
Output: 0
Explanation: Ignoring leading zeroes, both &#x201C;01&#x201D; and &#x201C;001&quot; represent the same number &#x201C;1&#x201D;

Example 5:
Input: version1 = &quot;1.0&quot;, version2 = &quot;1.0.0&quot;
Output: 0
Explanation: The first version number does not have a third level revision number, which means its third level revision number is default to &quot;0&quot;

&#xA0;

Note:

Version strings are composed of numeric strings separated by dots . and this numeric strings may have leading zeroes. 
Version strings do not start or end with dots, and they will not be two consecutive dots.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution165
{
    public class Solution
    {
        public void Init() { }

        public int CompareVersion(string version1, string version2) { }
    }
}
