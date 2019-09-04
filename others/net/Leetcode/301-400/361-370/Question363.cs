using System;
using System.Collections.Generic;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Max Sum of Rectangle No Larger Than K
    /// https://leetcode.com/problems/max-sum-of-sub-matrix-no-larger-than-k/
    ///
    /// Given a non-empty 2D matrix matrix and an integer k, find the max sum of a rectangle in the matrix such that its sum is no larger than k.
    ///
    /// Example:
    /// Given matrix = [
    ///     [1, 0, 1],
    ///     [0, -2, 3]
    /// ]
    /// k = 2
    ///
    /// The answer is 2. Because the sum of rectangle [[0, 1], [-2, 3]] is 2 and 2 is the max number no larger than k (k = 2).
    ///
    /// Note:
    /// The rectangle inside the matrix must have an area > 0.
    /// What if the number of rows is much larger than the number of columns?
    /// </summary>
    public class Question363
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(MaxSumSubmatrix(new int[,] { { 1, 0, 1 }, { 0, -2, 3 } }, 2));
            Program.PrintLine();
            Console.WriteLine(MaxSumSubmatrix(new int[,] { { 2, 2, -1 } }, 3));
            Program.PrintLine();
            Console.WriteLine(MaxSumSubmatrix(new int[,] { { 2, 2, -1 } }, 0));
        }

        public static int MaxSumSubmatrix(int[,] matrix, int k)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
                return 0;

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int m = Math.Max(row, col);
            int n = Math.Min(row, col);
            bool isRowLarger = false;

            if (row > col)
            {
                isRowLarger = true;
            }

            int result = Int32.MinValue;

            for (int c1 = 0; c1 < n; c1++)
            {
                int[] each = new int[m];

                for (int c2 = c1; c2 >= 0; c2--)
                {
                    for (int r = 0; r < m; r++)
                    {
                        each[r] += isRowLarger ? matrix[r, c2] : matrix[c2, r];
                    }

                    result = Math.Max(result, getLargestSumCloseToK(each, k));
                }
            }

            return result;
        }

        public static int getLargestSumCloseToK(int[] arr, int k)
        {
            int result = Int32.MinValue;

            SortedList<int, int> set = new SortedList<int, int>();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

                result = Math.Max(result, k);

                set.Add(i, sum);
            }

            return result;
        }
    }
}