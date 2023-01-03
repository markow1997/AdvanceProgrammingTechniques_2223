class Solution {
    fun containsDuplicate(nums: IntArray): Boolean {
        for (i in nums.indices) {
            for (j in nums.indices) {
                if (i == j) continue
                if (nums[i] == nums[j]) return true
            }
        }
        
        return false
    }
}

fun main() {
    println(Solution().containsDuplicate(intArrayOf(1,5,6,3,2)))
}
