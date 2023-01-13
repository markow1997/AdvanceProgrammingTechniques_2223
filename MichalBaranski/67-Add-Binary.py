class Solution:
    def addBinary(self, a: str, b: str) -> str:

        a = int(a,2) # 2 oznacza system binarny
        b = int(b,2) 

        return bin(a+b)[2:]
