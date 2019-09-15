// Url: https://leetcode.com/problems/last-stone-weight/

/*
1046. Last Stone Weight
Easy

We have a collection of rocks, each rock has a positive integer weight.

Each turn, we choose the two heaviest rocks and smash them together.  Suppose the stones have weights x and y with x <= y.  The result of this smash is:

If x == y, both stones are totally destroyed;
If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y-x.
At the end, there is at most 1 stone left.  Return the weight of this stone (or 0 if there are no stones left.)

 

Example 1:

Input: [2,7,4,1,8,1]
Output: 1
Explanation: 
We combine 7 and 8 to get 1 so the array converts to [2,4,1,1,1] then,
we combine 2 and 4 to get 2 so the array converts to [2,1,1,1] then,
we combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
we combine 1 and 1 to get 0 so the array converts to [1] then that's the value of last stone.
 

Note:

1 <= stones.length <= 30
1 <= stones[i] <= 1000
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem1046 {
    public class Solution {
        public void Init () {
            Console.WriteLine (LastStoneWeight (null));
            Console.WriteLine (LastStoneWeight (new int[] { 2, 7, 4, 1, 8, 1 }));
        }

        public int LastStoneWeight (int[] stones) {
            if (stones == null || stones.Length == 0) {
                return 0;
            }

            List<int> list = new List<int> ();
            Array.Sort (stones, (a, b) => (b - a));

            for (int i = 0; i < stones.Length; i++) {
                list.Add (stones[i]);
            }

            while (list.Count > 1) {
                int result = list[0] - list[1];

                list.Remove (list[0]);
                list.Remove (list[0]);

                if (result > 0) {
                    list.Add (result);
                    list.Sort ((a, b) => (b - a));
                }
            }

            if (list.Count > 0)
                return list[0];
            else
                return 0;
        }
    }
}