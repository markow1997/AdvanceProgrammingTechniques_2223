class Solution {
    fun lengthOfLastWord(s: String): Int {
        val splited = s.trim().split(" ")
        return splited[splited.size - 1].length
    }
}
