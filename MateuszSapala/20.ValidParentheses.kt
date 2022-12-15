//https://leetcode.com/problems/valid-parentheses/submissions/859356913/
class Solution {
    private val map = mapOf('(' to ')', '{' to '}', '[' to ']')

    fun isValid(s: String): Boolean {
        val expected = MutableList<Char>(0) { ' ' }
        for (i in s.indices) {
            if (map.containsKey(s[i])) {
                expected.add(0, map[s[i]]!!)
                continue
            }
            if (expected.isEmpty()) {
                return false
            }
            if (s[i] == expected[0]) {
                expected.removeAt(0)
                continue
            }
            return false
        }
        if (expected.isNotEmpty()) {
            return false
        }
        return true
    }
}

