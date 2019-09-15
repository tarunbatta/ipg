// Url:https://leetcode.com/problems/design-twitter

/*
355. Design Twitter
Medium

Design a simplified version of Twitter where users can post tweets, follow/unfollow another user and is able to see the 10 most recent tweets in the user's news feed. Your design should support the following methods:



postTweet(userId, tweetId): Compose a new tweet.
getNewsFeed(userId): Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent.
follow(followerId, followeeId): Follower follows a followee.
unfollow(followerId, followeeId): Follower unfollows a followee.



Example:
Twitter twitter = new Twitter();

// User 1 posts a new tweet (id = 5).
twitter.postTweet(1, 5);

// User 1's news feed should return a list with 1 tweet id -> [5].
twitter.getNewsFeed(1);

// User 1 follows user 2.
twitter.follow(1, 2);

// User 2 posts a new tweet (id = 6).
twitter.postTweet(2, 6);

// User 1's news feed should return a list with 2 tweet ids -> [6, 5].
// Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5.
twitter.getNewsFeed(1);

// User 1 unfollows user 2.
twitter.unfollow(1, 2);

// User 1's news feed should return a list with 1 tweet id -> [5],
// since user 1 is no longer following user 2.
twitter.getNewsFeed(1);
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem355 {
    public class Solution {
        public void Init () {
            int userId = 0;
            int tweetId = 0;
            int followerId = 0;
            int followeeId = 0;
            Twitter obj = new Twitter ();
            obj.PostTweet (userId, tweetId);
            IList<int> param_2 = obj.GetNewsFeed (userId);
            obj.Follow (followerId, followeeId);
            obj.Unfollow (followerId, followeeId);
        }

        public class Twitter {
            public Twitter () {

            }    

            // Compose a new tweet
            public void PostTweet (int userId, int tweetId) {

            }    

            // Retrieve the 10 most recent tweet ids in the user's news feed. 
            // Each item in the news feed must be posted by users who the user followed or by the user herself. 
            // Tweets must be ordered from most recent to least recent.
            public IList<int> GetNewsFeed (int userId) {
                return null;
            }    

            // Follower follows a followee. If the operation is invalid, it should be a no-op.  
            public void Follow (int followerId, int followeeId) {

            }    

            // Follower unfollows a followee. If the operation is invalid, it should be a no-op.
            public void Unfollow (int followerId, int followeeId) {

            }
        }
    }
}