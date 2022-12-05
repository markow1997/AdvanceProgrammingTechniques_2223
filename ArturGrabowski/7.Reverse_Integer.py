class Solution:
    def reverse(self, x: int) -> int:
        is_negative = False
        xString = str(x)
        if xString[0] == '-':
            is_negative = True
            xString = xString[1:]

        result = 0

        if is_negative:
            result = int('-' + xString[::-1])
        else:
            result = int(xString[::-1])

        if result < -2**31 or result > 2**31 - 1:
            result = 0

        return result
