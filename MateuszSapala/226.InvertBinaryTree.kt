//https://leetcode.com/problems/invert-binary-tree/submissions/849695155/
class Solution {
    fun invertTree(root: TreeNode?): TreeNode? {
        if (root == null) {
            return root;
        }
        val tmp = root.left
        root.left = invertTree(root.right);
        root.right = invertTree(tmp);
        return root
    }
}
