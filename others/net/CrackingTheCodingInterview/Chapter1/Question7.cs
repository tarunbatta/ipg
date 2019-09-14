﻿using System;

namespace TechByTarun.InterviewPreperationGuide.App.CrackingTheCodingInterview.Chapter1 {
    /// <summary>
    /// Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes,
    /// Write a method to rotate the image by 90 degrees. Can you do this in place?
    /// </summary>
    public class Question7 {
        public static void Init (string[] args) {
            int[, ] matrix1 = new int[, ] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[, ] matrix2 = new int[, ] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int n1 = 3;
            int n2 = 4;

            Console.WriteLine ("Original Martix1:");
            DisplayMatrix (matrix1, n1);

            Program.PrintLine ();

            Console.WriteLine ("Martix1 with 90 degree rotation:");
            RotateImageMatrixBy90 (matrix1, n1);

            Program.PrintLine ();

            Console.WriteLine ("Original Martix2:");
            DisplayMatrix (matrix2, n2);

            Program.PrintLine ();

            Console.WriteLine ("Martix2 with 90 degree rotation:");
            RotateImageMatrixBy90 (matrix2, n2);
        }

        private static void RotateImageMatrixBy90 (int[, ] matrix, int n) {
            for (int layer = 0; layer < n / 2; layer++) {
                int first = layer;
                int last = n - 1 - layer;

                for (int i = first; i < last; i++) {
                    int offset = i - first;

                    // save top
                    int top = matrix[first, i];

                    // left to top
                    matrix[first, i] = matrix[last - offset, first];

                    //bottom to left
                    matrix[last - offset, first] = matrix[last, last - offset];

                    // right to bottom
                    matrix[last, last - offset] = matrix[i, last];

                    // top to right
                    matrix[i, last] = top;
                }
            }

            DisplayMatrix (matrix, n);
        }

        private static void DisplayMatrix (int[, ] matrix, int n) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write (matrix[i, j] + "\t");
                }

                Console.WriteLine ("");
            }
        }
    }
}