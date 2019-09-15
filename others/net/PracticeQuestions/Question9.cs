using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreperationGuide.App.PracticeQuestions {
    /// <summary>
    /// Write a function to remve characters from a sentence
    /// </summary>
    public class Question9 {
        public static void Init (string[] args) {
            Console.WriteLine (RemoveCharactersFromString (string.Empty, string.Empty));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString (null, null));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString (" ", " "));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("0", "0"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("abcd", string.Empty));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString (string.Empty, "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("abcd", null));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString (null, "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("abcd", " "));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString (" ", "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("abcd", "b"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("b", "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("This is a test.", "aeiou"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString ("This is a test.", "z"));

            Program.PrintSeperator ();

            Console.WriteLine (RemoveCharactersFromString1 (string.Empty, string.Empty));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 (null, null));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 (" ", " "));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("0", "0"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("abcd", string.Empty));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 (string.Empty, "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("abcd", null));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 (null, "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("abcd", " "));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 (" ", "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("abcd", "b"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("b", "abcd"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("This is a test.", "aeiou"));
            Program.PrintLine ();
            Console.WriteLine (RemoveCharactersFromString1 ("This is a test.", "z"));
        }

        private static string RemoveCharactersFromString (string input, string toberemoved) {
            StringBuilder result = new StringBuilder ();

            if (!string.IsNullOrEmpty (input)) {
                for (int i = 0; i < input.Length; i++) {
                    bool match = false;

                    if (!string.IsNullOrEmpty (toberemoved)) {
                        for (int j = 0; j < toberemoved.Length; j++) {
                            if (input[i] == toberemoved[j]) {
                                match = true;
                                break;
                            }
                        }
                    }

                    if (!match) {
                        result.Append (input[i]);
                    }
                }
            }

            return result.ToString ();
        }

        private static string RemoveCharactersFromString1 (string input, string toberemoved) {
            StringBuilder result = new StringBuilder ();

            if (!string.IsNullOrEmpty (input)) {
                List<KeyValuePair<char, bool>> inputList = new List<KeyValuePair<char, bool>> ();

                for (int i = 0; i < input.Length; i++) {
                    inputList.Add (new KeyValuePair<char, bool> (input[i], false));
                }

                if (!string.IsNullOrEmpty (toberemoved)) {
                    for (int i = 0; i < toberemoved.Length; i++) {
                        var itemIndex = inputList.FindIndex (x => x.Key == toberemoved[i] && x.Value == false);

                        if (itemIndex >= 0) {
                            inputList[itemIndex] = new KeyValuePair<char, bool> (toberemoved[i], true);
                        }
                    }
                }

                foreach (var item in inputList) {
                    if (!item.Value) {
                        result.Append (item.Key);
                    }
                }
            }

            return result.ToString ();
        }
    }
}