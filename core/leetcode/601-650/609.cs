// Url:https://leetcode.com/problems/find-duplicate-file-in-system

/*
609. Find Duplicate File in System
Medium

Given a list of directory info including directory path, and all the files with contents in this directory, you need to find out all the groups of duplicate files in the file system in terms of their paths.

A group of duplicate files consists of at least two files that have exactly the same content.

A single directory info string in the input list has the following format:

&quot;root/d1/d2/.../dm f1.txt(f1_content) f2.txt(f2_content) ... fn.txt(fn_content)&quot;

It means there are n files (f1.txt, f2.txt ... fn.txt with content f1_content, f2_content ... fn_content, respectively) in directory root/d1/d2/.../dm. Note that n &gt;= 1 and m &gt;= 0. If m = 0, it means the directory is just the root directory.

The output is a list of group of duplicate file paths. For each group, it contains all the file paths of the files that have the same content. A file path is a string that has the following format:

&quot;directory_path/file_name.txt&quot;

Example 1:

Input:
[&quot;root/a 1.txt(abcd) 2.txt(efgh)&quot;, &quot;root/c 3.txt(abcd)&quot;, &quot;root/c/d 4.txt(efgh)&quot;, &quot;root 4.txt(efgh)&quot;]
Output:  
[[&quot;root/a/2.txt&quot;,&quot;root/c/d/4.txt&quot;,&quot;root/4.txt&quot;],[&quot;root/a/1.txt&quot;,&quot;root/c/3.txt&quot;]]


&#xA0;

Note:


	No order is required for the final output.
	You may assume the directory name, file name and file content only has letters and digits, and the length of file content is in the range of [1,50].
	The number of files given is in the range of [1,20000].
	You may assume no files or directories share the same name in the same directory.
	You may assume each given directory info represents a unique directory. Directory path and file info are separated by a single blank space.


&#xA0;
Follow-up beyond contest:


	Imagine you are given a real file system, how will you search files? DFS or BFS?
	If the file content is very large (GB level), how will you modify your solution?
	If you can only read the file by 1kb each time, how will you modify your solution?
	What is the time complexity of your modified solution? What is the most time-consuming part and memory consuming part of it? How to optimize?
	How to make sure the duplicated files you find are not false positive?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution609
{
    public class Solution
    {
        public void Init() { }

        public IList<IList<string>> FindDuplicate(string[] paths) { }
    }
}
