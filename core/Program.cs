﻿using System;
using InterviewPreperationGuide.Core;

namespace InterviewPreperationGuide.Core {
    class Program {
        static void Main (string[] args) {
            //Algorithms.Search.Dijkstra.Init ();
            //Algorithms.Others.LongestCommonSubstring.Init();

            var lc = new LeetCode.problem269.Solution ();
            lc.Init ();
        }
    }
}