// Url:https://leetcode.com/problems/russian-doll-envelopes

/*
354. Russian Doll Envelopes
Hard

You have a number of envelopes with widths and heights given as a pair of integers (w, h). One envelope can fit into another if and only if both the width and height of one envelope is greater than the width and height of the other envelope.

What is the maximum number of envelopes can you Russian doll? (put one inside other)

Note:
Rotation is not allowed.

Example:


Input: [[5,4],[6,4],[6,7],[2,3]]
Output: 3 
Explanation: The maximum number of envelopes you can Russian doll is 3 ([2,3] => [5,4] => [6,7]).
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem354
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine(MaxEnvelopes(null));
            Console.WriteLine(MaxEnvelopes(new int[][] {
                new int[] { 5, 4 },
                    new int[] { 6, 4 },
                    new int[] { 6, 7 },
                    new int[] { 2, 3 }
            }));
        }

        public int MaxEnvelopes(int[][] envelopes)
        {
            int result = 0;

            if (envelopes != null)
            {
                int rows = envelopes.GetLength(0);
                int cols = envelopes.GetLength(1);

                if (rows > 0 && cols > 0)
                {
                    DollEnvelope[] env = new DollEnvelope[rows];

                    for (int i = 0; i < rows; i++)
                    {
                        env[i] = new DollEnvelope(envelopes[i][0], envelopes[i][1]);
                    }

                    Array.Sort(env);

                    int[] dp = new int[rows];

                    for (int i = 0; i < rows; i++)
                    {
                        int currentIndex = Array.BinarySearch(dp, 0, result, env[i].height);

                        if (currentIndex < 0)
                        {
                            currentIndex = ~currentIndex;
                        }

                        dp[currentIndex] = env[i].height;

                        if (currentIndex == result)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }

    public class DollEnvelope : IComparable<DollEnvelope>
    {
        public int width { get; set; }
        public int height { get; set; }

        public DollEnvelope(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int CompareTo(DollEnvelope de)
        {
            if (this.width == de.width)
            {
                return de.height - this.height;
            }
            else
            {
                return this.width - de.width;
            }
        }
    }
}