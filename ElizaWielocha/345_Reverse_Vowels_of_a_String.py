'''
Given a string s, reverse only all the vowels in the string and return it.
The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

EXAMPLE 1:
Input: s = "hello"
Output: "holle"

EXAMPLE 2:

Input: s = "leetcode"
Output: "leotcede"
'''

class Solution:
    def reverseVowels(self, s: str) -> str:
        samogloski = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
        wordLetters = list()
        for letter in s:
            if letter in samogloski:
                wordLetters.append(letter)

        newS = ''
        i = len(wordLetters) -1

        for letter in s:
            if letter in samogloski:
                newS += wordLetters[i]
                i = i-1
            else:
                newS += letter
        
        return newS

