'''
Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
'''

class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        """
        :type s: str
        :rtype: int
        """
        count = 0
        s = s.strip()
        
        start = len(s)-1
        for i in range(start, -1, -1):
            if s[i] == ' ':
                 break          
            count += 1
            
        return count
