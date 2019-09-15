﻿using System;
using System.Text;

namespace InterviewPreperationGuide.Core.CrackingTheCodingInterview.Chapter1 {
    /// <summary>
    /// String Compression: Implement a method to perform basic string compression using the counts
    /// of repeated characters. For example, the string aabcccccaaa would become
    /// a2blc5a3. If the "compressed" string would not become smaller than the original
    /// string, your method should return the original string.
    /// </summary>
    public class Question6 {
        public static void Init (string[] args) {
            Console.WriteLine ("Empty: " + CompressString (""));
            Console.WriteLine ("Null: " + CompressString (null));
            Console.WriteLine ("abcd: " + CompressString ("abcd"));
            Console.WriteLine ("aabcccccaaa: " + CompressString ("aabcccccaaa"));
        }

        private static string CompressString (string input) {
            StringBuilder result = new StringBuilder ();

            if (!string.IsNullOrEmpty (input)) {
                char currentCharacter = char.MinValue;
                int currentCharacterCount = 0;

                for (int i = 0; i < input.Length; i++) {
                    if (i == 0) {
                        currentCharacter = input[0];
                    }

                    if (currentCharacter == input[i]) {
                        currentCharacterCount++;
                    } else {
                        result.Append (currentCharacter.ToString ());
                        result.Append (currentCharacterCount.ToString ());

                        currentCharacter = input[i];
                        currentCharacterCount = 1;
                    }

                    if (i == input.Length - 1) {
                        result.Append (currentCharacter.ToString ());
                        result.Append (currentCharacterCount.ToString ());
                    }
                }
            }

            return result.ToString ();
        }
    }
}