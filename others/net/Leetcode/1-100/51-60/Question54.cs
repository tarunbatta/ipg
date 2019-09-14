using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Spiral Matrix
    /// https://leetcode.com/problems/spiral-matrix/
    ///
    /// Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
    ///
    /// For example,
    /// Given the following matrix:
    /// [
    ///     [ 1, 2, 3 ],
    ///     [ 4, 5, 6 ],
    ///     [ 7, 8, 9 ]
    /// ]
    /// You should return [1,2,3,6,9,8,7,4,5].
    /// </summary>
    public class Question54 {
        public static void Init (string[] args) {
            PrintSpiralMatrix (new int[, ] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }
            });

            Program.PrintLine ();

            PrintSpiralMatrix (new int[, ] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 }
            });
        }

        private static void PrintSpiralMatrix (int[, ] matrix) {
            string result = string.Empty;

            int height = matrix.GetLength (0);
            int width = matrix.GetLength (1);

            PrintMatrix (matrix, height, width);

            int rowStart = 0;
            int rowEnd = height;
            int colStart = 0;
            int colEnd = width;

            while ((rowStart < rowEnd) && (colStart < colEnd)) {
                for (int i = colStart; i < colEnd; i++) {
                    result += matrix[rowStart, i] + " ";
                }
                rowStart++;

                for (int i = rowStart; i < rowEnd; i++) {
                    result += matrix[i, colEnd - 1] + " ";
                }
                colEnd--;

                if (rowStart < rowEnd) {
                    for (int i = colEnd - 1; i >= colStart; i--) {
                        result += matrix[rowEnd - 1, i] + " ";
                    }
                    rowEnd--;
                }

                if (colStart < colEnd) {
                    for (int i = rowEnd - 1; i >= rowStart; i--) {
                        result += matrix[i, colStart] + " ";
                    }
                    colStart++;
                }
            }

            Console.WriteLine ("Output: " + result);
        }

        private static void PrintMatrix (int[, ] matrix, int height, int width) {
            Console.WriteLine ("Input: ");

            for (int i = 0; i < height; i++) {
                string str = string.Empty;

                for (int j = 0; j < width; j++) {
                    str += matrix[i, j] + " ";
                }

                Console.WriteLine (str);
            }

            Console.WriteLine (string.Empty);
        }
    }
}