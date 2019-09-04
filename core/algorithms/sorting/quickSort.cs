using System;

namespace InterviewPreperationGuide.Core.Algorithms.Sorting {
    public class QuickSort {
        public static void Init () {
            _QuickSort (null);
            _QuickSort (new int[0]);
            _QuickSort (new int[] { 1, 7, 5, 23, 9, 34, 12, 100, 2, 6, 0, -5, 25 });
        }

        public static void _QuickSort (int[] arr) {
            if (arr != null && arr.Length > 0) {
                Sort (arr, 0, arr.Length - 1);
            }

            Display (arr);
        }

        public static void Sort (int[] arr, int low, int high) {
            if (low < high) {
                //pi is partitioning index, arr[pi] is now at right place
                int pi = Partition (arr, low, high);

                // Recursively sort elements before partition and after partition
                Sort (arr, low, pi - 1);
                Sort (arr, pi + 1, high);
            }
        }

        public static int Partition (int[] arr, int low, int high) {
            int pivot = arr[high];
            int i = (low - 1); // index of smaller element

            for (int j = low; j < high; j++) {
                // If current element is smaller than or equal to pivot
                if (arr[j] <= pivot) {
                    i++;

                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void Display (int[] arr) {
            if (arr != null) {
                for (int x = 0; x < arr.Length; x++) {
                    Console.Write (arr[x] + " ");
                }
            }

            Console.WriteLine ();
        }
    }
}