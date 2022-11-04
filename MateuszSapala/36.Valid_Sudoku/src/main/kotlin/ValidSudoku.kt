class Solution {
    //https://leetcode.com/problems/valid-sudoku/
    fun isValidSudoku(board: Array<CharArray>): Boolean {
        for (i in indices) {
            //Rows
            val row = Array(9) { 0 }
            for (j in indices) {
                val value = board[i][j]
                if (value != EMPTY_FIELD) {
                    row[value.toString().toInt() - 1]++
                }
            }
            if (!oneOrLessSameDigit(row)) {
                return false
            }

            //Columns
            val column = Array(9) { 0 }
            for (j in indices) {
                val value = board[j][i]
                if (value != EMPTY_FIELD) {
                    column[value.toString().toInt() - 1]++
                }
            }
            if (!oneOrLessSameDigit(column)) {
                return false
            }
        }
        return true
    }

    private fun oneOrLessSameDigit(column: Array<Int>): Boolean {
        column.forEach {
            if (it > 1) {
                return false
            }
        }
        return true
    }

    companion object {
        private const val EMPTY_FIELD = '.'
        private val indices: IntRange get() = IntRange(0, 8)
    }
}