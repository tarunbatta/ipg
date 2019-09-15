using System;
using System.Collections;

namespace InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Minimum Window Substring
    /// https://leetcode.com/problems/minimum-window-substring/
    ///
    /// Given a string S and a string T, find the minimum window in S which will
    /// contain all the characters in T in complexity O(n).
    ///
    /// For example,
    /// S = "ADOBECODEBANC"
    /// T = "ABC"
    /// Minimum window is "BANC".
    ///
    /// Note:
    /// If there is no such window in S that covers all characters in T, return the empty string "".
    /// If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.
    /// </summary>
    public class Question76 {
        public static void Init (string[] args) {
            MinWindow ("ADOBECODEBANC", null);
            Program.PrintLine ();
            MinWindow (null, "ABC");
            Program.PrintLine ();
            MinWindow ("ADOBECODEBANC", "ABC");
            Program.PrintLine ();
            MinWindow ("dabceabcg", "deg");
            Program.PrintLine ();
            MinWindow ("abcdedefg", "deg");
            Program.PrintLine ();
            MinWindow ("abcdedefg", "xyz");
            Program.PrintLine ();
            MinWindow ("eaebeccdeefeggh", "eee");
        }

        public static string MinWindow (string s, string t) {
            string result = string.Empty;

            if (!string.IsNullOrEmpty (s) && !string.IsNullOrEmpty (t)) {
                char[] arrS = s.ToCharArray ();
                char[] arrT = t.ToCharArray ();

                Hashtable hashT = new Hashtable ();

                for (int i = 0; i < arrT.Length; i++) {
                    if (!hashT.ContainsKey (arrT[i])) {
                        hashT.Add (arrT[i], 1);
                    } else {
                        hashT[arrT[i]] = (int) hashT[arrT[i]] + 1;
                    }
                }

                int start = 0;
                int minlen = arrS.Length + 1;
                int match = 0;

                Hashtable hashS = new Hashtable ();

                for (int i = 0; i < arrS.Length; i++) {
                    if (hashT.ContainsKey (arrS[i])) {
                        if (hashS.ContainsKey (arrS[i])) {
                            if ((int) hashS[arrS[i]] < (int) hashT[arrS[i]]) {
                                match++;
                            }

                            hashS[arrS[i]] = (int) hashS[arrS[i]] + 1;
                        } else {
                            hashS.Add (arrS[i], 1);
                            match++;
                        }
                    }

                    if (match == arrT.Length) {
                        while (!hashS.ContainsKey (arrS[start]) || (int) hashS[arrS[start]] > (int) hashT[arrS[start]]) {
                            if (hashS.ContainsKey (arrS[start]) && (int) hashS[arrS[start]] > (int) hashT[arrS[start]]) {
                                hashS[arrS[start]] = (int) hashS[arrS[start]] - 1;
                            }

                            start++;
                        }

                        int end = i + 1 - start;

                        if (end < minlen) {
                            result = s.Substring (start, end);
                            minlen = end;
                        }
                    }
                }
            }

            Console.WriteLine ("Minimum window of '" + t + "' in '" + s + "' is : '" + result + "'");

            return result;
        }
    }
}