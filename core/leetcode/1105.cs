// Url:https://leetcode.com/problems/filling-bookcase-shelves

/*
1105. Filling Bookcase Shelves
Medium

We have a sequence of books: the i-th book has thickness books[i][0] and height books[i][1].

We want to place these books in order&#xA0;onto bookcase shelves that have total width shelf_width.

We choose&#xA0;some of the books to place on this shelf (such that the sum of their thickness is &lt;= shelf_width), then build another level of shelf of the bookcase so that the total height of the bookcase has increased by the maximum height of the books we just put down.&#xA0; We repeat this process until there are no more books to place.

Note again that at each step of the above&#xA0;process, the order of the books we place is the same order as the given sequence of books.&#xA0; For example, if we have an ordered list of 5&#xA0;books, we might place the first and second book onto the first shelf, the third book on the second shelf, and the fourth and fifth book on the last shelf.

Return the minimum possible height that the total bookshelf can be after placing shelves in this manner.

&#xA0;
Example 1:

Input: books = [[1,1],[2,3],[2,3],[1,1],[1,1],[1,1],[1,2]], shelf_width = 4
Output: 6
Explanation:
The sum of the heights of the 3 shelves are 1 + 3 + 2 = 6.
Notice that book number 2 does not have to be on the first shelf.


&#xA0;
Constraints:


	1 &lt;= books.length &lt;= 1000
	1 &lt;= books[i][0] &lt;= shelf_width &lt;= 1000
	1 &lt;= books[i][1] &lt;= 1000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1105
{
    public class Solution
    {
        public void Init() { }

        public int MinHeightShelves(int[][] books, int shelf_width) { }
    }
}
