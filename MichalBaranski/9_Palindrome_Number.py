'''
Given an integer x, return true if x is a palindrome, and false otherwise.

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

'''



class Solution:
    def isPalindrome(self, x: int) -> bool:
        
        
        if x < 0:
            return False
        
        
        a = 0
        temp = x
        
        while temp:
            a = (a * 10) + (temp % 10)
            temp //= 10
            
            
        return x == a
