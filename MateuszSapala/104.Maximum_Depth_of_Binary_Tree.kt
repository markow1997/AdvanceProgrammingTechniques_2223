/**
 * https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/877509864/
 * Example:
 * var ti = TreeNode(5)
 * var v = ti.`val`
 * Definition for a binary tree node.
 * class TreeNode(var `val`: Int) {
 *     var left: TreeNode? = null
 *     var right: TreeNode? = null
 * }
 */
class Solution {
    fun maxDepth(root: TreeNode?, size: Int = 1): Int {
        if (size == 1 && root == null) return 0
        val right = if (root?.right != null) maxDepth(root?.right, size + 1) else size
        val left = if (root?.left != null) maxDepth(root?.left, size + 1) else size
        return if (right >= left) right else left
    }
}