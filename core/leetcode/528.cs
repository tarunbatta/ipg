// Url:https://leetcode.com/problems/random-pick-with-weight

/*
528. Random Pick with Weight
Medium

Given an array w of positive integers, where w[i] describes the weight of index i, write a function pickIndex which randomly picks an index in proportion to its weight.

Note:


	1 <= w.length <= 10000
	1 <= w[i] <= 10^5
	pickIndex will be called at most 10000 times.


Example 1:

Input: 
["Solution","pickIndex"]
[[[1]],[]]
Output: [null,0]



Example 2:

Input: 
["Solution","pickIndex","pickIndex","pickIndex","pickIndex","pickIndex"]
[[[1,3]],[],[],[],[],[]]
Output: [null,0,1,1,1,0]


Explanation of Input Syntax:

The input is two lists: the subroutines called and their arguments. Solution's constructor has one argument, the array w. pickIndex has no arguments. Arguments are always wrapped with a list, even if there aren't any.
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem528
{
    public class Solution
    {
        public void Init()
        {
            Solution obj = new Solution(null);
            int param_1 = obj.PickIndex();
        }

        List<int> psum = new List<int>();
        int total = 0;
        Random rand = new Random();

        public Solution(int[] w)
        {
            foreach (int x in w)
            {
                total += x;
                psum.Add(total);
            }
        }

        public int PickIndex()
        {
            int targ = rand.Next(total);
            int lo = 0;
            int hi = psum.Count - 1;

            while (lo != hi)
            {
                int mid = (lo + hi) / 2;
                if (targ >= psum[mid]) lo = mid + 1;
                else hi = mid;
            }

            return lo;
        }
    }
}