'''
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
Given a roman numeral, convert it to an integer.

EXAMPLE:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

'''

class Solution:
    def romanToInt(self, s: str) -> int:
        roman = { 'I':1,
                'V':5,
                'X':10,
                'L':50,
                'C':100,
                'D':500,
                'M':1000
                }

        sumVal = 0

        for i in range (len(s)-1):
            if roman[s[i]] < roman[s[i+1]]:
                sumVal = sumVal - roman[s[i]]
            else:
                sumVal = sumVal + roman[s[i]]

        return sumVal + roman[s[-1]]
