// Url:https://leetcode.com/problems/encode-and-decode-tinyurl

/*
535. Encode and Decode TinyURL
Medium

Note: This is a companion problem to the System Design problem: Design TinyURL.

TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.

Design the encode and decode methods for the TinyURL service. There is no restriction on how your encode/decode algorithm should work. You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem535
{
    public class Solution
    {
        public void Init()
        {
            Codec codec = new Codec();
            codec.decode(codec.encode(null));
        }
    }

    public class Codec
    {
        // Encodes a URL to a shortened URL    
        public string encode(string longUrl)
        {
            return null;
        }

        // Decodes a shortened URL to its original URL.    
        public string decode(string shortUrl)
        {
            return null;
        }
    }
}