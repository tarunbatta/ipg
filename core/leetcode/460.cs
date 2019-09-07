// Url:https://leetcode.com/problems/lfu-cache

/*
460. LFU Cache
Hard

Design and implement a data structure for Least Frequently Used (LFU) cache. It should support the following operations: get and put.



get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
put(key, value) - Set or insert the value if the key is not already present. When the cache reaches its capacity, it should invalidate the least frequently used item before inserting a new item. For the purpose of this problem, when there is a tie (i.e., two or more keys that have the same frequency), the least recently used key would be evicted.


Follow up:
Could you do both operations in O(1) time complexity?

Example:
LFUCache cache = new LFUCache(2);

cache.put(1, 1);
cache.put(2, 2);
cache.get(1);       // returns 1
cache.put(3, 3);    // evicts key 2
cache.get(2);       // returns -1 (not found)
cache.get(3);       // returns 3.
cache.put(4, 4);    // evicts key 1.
cache.get(1);       // returns -1 (not found)
cache.get(3);       // returns 3
cache.get(4);       // returns 4
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution460 {
    public class LFUCache {
        public LFUCache (int capacity) {
            LFUCache obj = new LFUCache (capacity);
            int param_1 = obj.Get (0);
            obj.Put (0, 0);
        }

        public int Get (int key) {
            return 0;
        }

        public void Put (int key, int value) {

        }
    }
}