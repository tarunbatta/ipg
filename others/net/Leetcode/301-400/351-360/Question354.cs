using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Russian Doll Envelopes
    /// https://leetcode.com/problems/russian-doll-envelopes/
    ///
    /// You have a number of envelopes with widths and heights given as a pair of integers (w, h).
    /// One envelope can fit into another if and only if both the width and height of one envelope
    /// is greater than the width and height of the other envelope.
    ///
    /// What is the maximum number of envelopes can you Russian doll? (put one inside other)
    ///
    /// Example:
    /// Given envelopes = [[5, 4],[6, 4],[6, 7],[2, 3]], the maximum number of envelopes
    /// you can Russian doll is 3 ([2,3] => [5,4] => [6,7]).
    /// </summary>
    public class Question354
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(MaxEnvelopes(null));
            Program.PrintLine();
            Console.WriteLine(MaxEnvelopes(new int[,] {
                { 5, 4 },
                { 6, 4 },
                { 6, 7 },
                { 2, 3 }
            }));
        }

        public static int MaxEnvelopes(int[,] envelopes)
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
                        env[i] = new DollEnvelope(envelopes[i, 0], envelopes[i, 1]);
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