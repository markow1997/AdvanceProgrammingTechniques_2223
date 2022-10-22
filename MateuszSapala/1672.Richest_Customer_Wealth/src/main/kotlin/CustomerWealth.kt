class Solution {
//    fun wealth(accounts: Array<IntArray>): Int {
//        return accounts.maxOf { array -> array.sum() }
//    }

    //https://leetcode.com/problems/richest-customer-wealth/
    //https://leetcode.com/problems/richest-customer-wealth/submissions/822826291/
    fun wealth(accounts: Array<IntArray>): Int {
        var maxWealth = 0
        accounts.forEach { account ->
            run {
                var wealth = 0
                account.forEach { money -> wealth += money }
                if (wealth > maxWealth) {
                    maxWealth = wealth
                }
            }
        }
        return maxWealth
    }
}