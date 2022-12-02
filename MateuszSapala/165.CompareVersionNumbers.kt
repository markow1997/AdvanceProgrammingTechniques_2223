class Solution {
    //https://leetcode.com/problems/compare-version-numbers/submissions/853478836/
    fun compareVersion(version1: String, version2: String): Int {
        val v1 = version1.split(".")
        val v2 = version2.split(".")
        val maxI = if (v1.size > v2.size) v1.size else v2.size
        for (i in 0..maxI - 1) {
            val a = if (i < v1.size) v1[i].replaceFirst("[0]?", "") else "0"
            val b = if (i < v2.size) v2[i].replaceFirst("[0]?", "") else "0"
            if (a.toInt() > b.toInt()) {
                return 1
            }
            if (a.toInt() < b.toInt()) {
                return -1
            }
        }
        return 0;
    }
}
