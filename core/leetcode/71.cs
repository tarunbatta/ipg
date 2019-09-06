// Url:https://leetcode.com/problems/simplify-path

/*
71. Simplify Path
Medium

Given an absolute path for a file (Unix-style), simplify it. Or in other words, convert it to the canonical path.

In a UNIX-style file system, a period .&#xA0;refers to the current directory. Furthermore, a double period ..&#xA0;moves the directory up a level. For more information, see:&#xA0;Absolute path&#xA0;vs&#xA0;relative&#xA0;path&#xA0;in&#xA0;Linux/Unix

Note that the returned canonical path must always begin&#xA0;with a slash /, and there must be only a single slash /&#xA0;between two directory names.&#xA0;The last directory name (if it exists) must not&#xA0;end with a trailing /. Also, the canonical path must be the shortest string&#xA0;representing the absolute path.

&#xA0;

Example 1:

Input: &quot;/home/&quot;
Output: &quot;/home&quot;
Explanation: Note that there is no trailing slash after the last directory name.


Example 2:

Input: &quot;/../&quot;
Output: &quot;/&quot;
Explanation: Going one level up from the root directory is a no-op, as the root level is the highest level you can go.


Example 3:

Input: &quot;/home//foo/&quot;
Output: &quot;/home/foo&quot;
Explanation: In the canonical path, multiple consecutive slashes are replaced by a single one.


Example 4:

Input: &quot;/a/./b/../../c/&quot;
Output: &quot;/c&quot;


Example 5:

Input: &quot;/a/../../b/../c//.//&quot;
Output: &quot;/c&quot;


Example 6:

Input: &quot;/a//b////c/d//././/..&quot;
Output: &quot;/a/b/c&quot;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution71
{
    public class Solution
    {
        public void Init() { }

        public string SimplifyPath(string path) { }
    }
}
