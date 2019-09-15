using System;
using System.Linq;

namespace InterviewPreperationGuide.App.CrackingTheCodingInterview.Chapter1 {
    /// <summary>
    /// Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public class Question2 {
        public static void Init (string[] args) {
            Console.WriteLine (CheckStringPermutation1 ("", ""));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 (null, null));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 ("", null));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 (null, ""));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 ("abcd", "efgh"));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 ("abcd", "bdac"));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 ("abcd", "bdAc"));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation1 ("abcde", "bdac"));

            Program.PrintSeperator ();

            Console.WriteLine (CheckStringPermutation2 ("", ""));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 (null, null));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 ("", null));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 (null, ""));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 ("abcd", "efgh"));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 ("abcd", "bdac"));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 ("abcd", "bdAc"));
            Program.PrintLine ();
            Console.WriteLine (CheckStringPermutation2 ("abcde", "bdac"));
        }

        private static string SortString (string input) {
            string result = string.Empty;

            if (!string.IsNullOrEmpty (input)) {
                char[] charactersInString = input.ToCharArray ();
                Array.Sort (charactersInString);
                result = new string (charactersInString);
            }

            return result;
        }

        private static bool CheckStringPermutation1 (string inputA, string inputB) {
            if (string.IsNullOrEmpty (inputA) || string.IsNullOrEmpty (inputB)) {
                return false;
            }

            if (inputA.Length != inputB.Length) {
                return false;
            }

            return string.Compare (SortString (inputA), SortString (inputB)) == 0;
        }

        private static bool CheckStringPermutation2 (string inputA, string inputB) {
            if (string.IsNullOrEmpty (inputA) || string.IsNullOrEmpty (inputB)) {
                return false;
            }

            if (inputA.Length != inputB.Length) {
                return false;
            }

            int[] letters = new int[256];
            char[] charactersinStringA = inputA.ToArray ();

            for (int i = 0; i < inputA.Length; i++) {
                int characterValue = Convert.ToInt32 (inputA[i]);
                letters[characterValue]++;
            }

            for (int i = 0; i < inputB.Length; i++) {
                int characterValue = Convert.ToInt32 (inputB[i]);
                letters[characterValue]--;

                if (letters[characterValue] < 0) {
                    return false;
                }
            }

            return true;
        }
    }
}