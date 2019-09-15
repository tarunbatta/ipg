﻿namespace InterviewPreperationGuide.Core.CrackingTheCodingInterview.Chapter17 {
    /// <summary>
    /// Sparse Similarity: The similarity of two documents (each with distinct words) is defined to be the
    /// size of the intersection divided by the size of the union.For example, if the documents consist of
    /// integers, the similarity of {1, 5, 3} and {1, 7, 2, 3} is e. 4, because the intersection has size
    /// 2 and the union has size 5.
    /// We have a long list of documents(with distinct values and each with an associated ID) where the
    /// similarity is believed to be "sparse". That is, any two arbitrarily selected documents are very likely to
    /// have similarity 0. Design an algorithm that returns a list of pairs of document IDs and the associated
    /// similarity.
    /// Print only the pairs with similarity greater than O.Empty documents should not be printed at all.For
    /// simplicity, you may assume each document is represented as an array of distinct integers.
    /// EXAMPLE
    /// Input:
    /// 13: { 14, 15, 100, 9, 3}
    /// 16: {32, 1, 9, 3, 5}
    /// 19: {15, 29, 2, 6, 8, 7}
    /// 24: {7, l0}
    /// Output:
    /// ID1, ID2    :   SIMILARITY
    /// 13, 19      :   0.1
    /// 13, 16      :   0.25
    /// 19, 24      :   0.14285714285714285
    /// </summary>
    public class Question26 {
        public static void Init (string[] args) { }
    }
}