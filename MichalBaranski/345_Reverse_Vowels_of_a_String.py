'''
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.


Input: s = "hello"
Output: "holle"

Input: s = "leetcode"
Output: "leotcede"

'''
class Solution:
    def reverseVowels(self, s: str) -> str:
        
        vowels = {'a', 'e', 'i', 'o', 'u'}
    
        wynik = []
        in_s = []
        
        for i in s:
            
            if i.lower() in vowels:
                in_s.append(i)
                wynik.append(None)
                
            else:
                wynik.append(i)
                
                
        for j, item in enumerate(wynik):
            
            if not item:
                wynik[j] = in_s.pop()
                
                
        return "".join(wynik)
