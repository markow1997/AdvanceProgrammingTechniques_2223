//https://leetcode.com/problems/power-of-two/submissions/860357377/
class Solution {
    fun isPowerOfTwo(n: Int): Boolean {
        var x = n
        if (x < 1) return false
        while (x % 2 == 0) {
            x /= 2
        }
        return x == 1
    }
}
