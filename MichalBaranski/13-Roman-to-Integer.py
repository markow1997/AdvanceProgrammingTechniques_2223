class Solution:
    def romanToInt(self, s: str) -> int:

        wartoscInt = 0
        slownik ={'I':1, 'V':5, 'X':10, 'L':50, 'C':100, 'D':500, 'M':1000, 'IV':4, 'IX':9}

        for i in range(len(s)):
            if i < len(s)-1 and slownik[s[i+1]] > slownik[s[i]]:
                wartoscInt -= slownik[s[i]]
            else:
                wartoscInt += slownik[s[i]]

        return wartoscInt
