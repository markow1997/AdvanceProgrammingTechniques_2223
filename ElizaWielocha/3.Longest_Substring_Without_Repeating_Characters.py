'''
Given a string s, find the length of the longest substring without repeating characters.

EXAMPLE 1
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

EXAMPLE 2
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

EXAMPLE 3
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
'''
class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if len(s) == 1: 
            return 1

        count = 0
        result = ''

        for letter in s:
            if letter not in result:
                result += letter
            else:
                result = result[result.index(letter)+1:] + letter
            if len(result) >= count:
                count = len(result)

        return count   


