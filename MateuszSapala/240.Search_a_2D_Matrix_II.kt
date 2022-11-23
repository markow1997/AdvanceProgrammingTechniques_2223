class Solution {
    //https://leetcode.com/problems/search-a-2d-matrix-ii/submissions/846010246/
    fun searchMatrix(matrix: Array<IntArray>, target: Int): Boolean {
        val (found, row, col) = searchDiagonal(matrix, target);
        if (found) {
            return true
        }

        if (searchRow(matrix, target, row, col)) {
            return true
        }

        if (searchCol(matrix, target, row, col)) {
            return true
        }

        return false
    }

    companion object {
        fun searchDiagonal(matrix: Array<IntArray>, target: Int): Triple<Boolean, Int, Int> {
            var i = 0
            var j = 0
            while (matrix[i][j] < target) {
                if (i == matrix.size - 1 && j == matrix[i].size - 1) {
                    return Triple(false, 0, 0)
                }
                if (i == matrix.size - 1) {
                    j++
                    continue
                }
                if (j == matrix[i].size - 1) {
                    i++
                    continue
                }
                i++
                j++
            }
            if (matrix[i][j] == target) {
                return Triple(true, 0, 0)
            }
            return Triple(false, i, j)
        }

        fun searchRow(matrix: Array<IntArray>, target: Int, row: Int, col: Int): Boolean {
            var i = row - 1
            while (i >= 0) {
                var j = col
                while (j < matrix[i].size && matrix[i][j] <= target) {
                    if (matrix[i][j] == target) {
                        return true
                    }
                    j++
                }
                i--
            }
            return false
        }

        fun searchCol(matrix: Array<IntArray>, target: Int, row: Int, col: Int): Boolean {
            var j = col - 1
            while (j >= 0) {
                var i = row
                while (i < matrix.size && matrix[i][j] <= target) {
                    if (matrix[i][j] == target) {
                        return true
                    }
                    i++
                }
                j--
            }
            return false
        }
    }
}
