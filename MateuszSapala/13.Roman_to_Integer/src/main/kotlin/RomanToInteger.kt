class Solution {
    //https://leetcode.com/problems/roman-to-integer/
    fun romanToInt(s: String): Int {
        var result = 0
        for (i in s.length - 1 downTo 0) {
            val current = romanToIntConversionMap[s[i]]!!
            val previous = if (i < s.length - 1) romanToIntConversionMap[s[i + 1]]!! else 0
            result = if (current >= previous) result + current else result - current
        }
        return result
    }

    companion object {
        val romanToIntConversionMap = mapOf(
            'I' to 1,
            'V' to 5,
            'X' to 10,
            'L' to 50,
            'C' to 100,
            'D' to 500,
            'M' to 1000
        )
    }
}