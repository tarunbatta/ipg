﻿using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Island Perimeter
    /// https://leetcode.com/problems/island-perimeter/
    ///
    /// You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water.
    /// Grid cells are connected horizontally/vertically (not diagonally).
    /// The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).
    /// The island doesn't have "lakes" (water inside that isn't connected to the water around the island).
    /// One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100.
    /// Determine the perimeter of the island.
    ///
    /// Example:
    /// [
    ///     [0,1,0,0],
    ///     [1,1,1,0],
    ///     [0,1,0,0],
    ///     [1,1,0,0]
    /// ]
    ///
    /// Answer: 16
    /// </summary>
    public class Question463 {
        public static void Init (string[] args) {
            Console.WriteLine (GetIslandPerimeter (new int[, ] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 }
            }));
        }

        public static int GetIslandPerimeter (int[, ] grid) {
            int result = 0;

            if (grid != null) {
                int rows = grid.GetLength (0);
                int cols = grid.GetLength (1);

                if (rows > 0 && cols > 0) {
                    for (int i = 0; i < rows; i++) {
                        for (int j = 0; j < cols; j++) {
                            if (grid[i, j] == 1) {
                                result += GetParameterForLand (grid, i, j);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public static int GetParameterForLand (int[, ] grid, int i, int j) {
            int result = 0;

            if (grid != null) {
                int rows = grid.GetLength (0);
                int cols = grid.GetLength (1);

                if (rows > 0 && cols > 0) {
                    // top
                    if ((j == 0) || (j != 0 && grid[i, j - 1] == 0)) {
                        result++;
                    }

                    //right
                    if ((j == cols - 1) || (j != cols - 1 && grid[i, j + 1] == 0)) {
                        result++;
                    }

                    //bottom
                    if ((i == rows - 1) || (i != rows - 1 && grid[i + 1, j] == 0)) {
                        result++;
                    }

                    //left
                    if ((i == 0) || (i != 0 && grid[i - 1, j] == 0)) {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}