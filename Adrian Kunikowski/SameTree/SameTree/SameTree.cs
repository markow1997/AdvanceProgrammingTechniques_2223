using System;

namespace SameTree
{
    internal class SameTree
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q != null)
            {
                return false;
            }
            else if (p != null && q == null)
            {
                return false;
            }
            else if (p == null && q == null)
            {
                return true;
            }

            bool testLewy = IsSameTree(p.left, q.left);
            bool testWart = false;
            if (p.val == q.val)
            {
                testWart = true;
            }
            bool testPrawy = IsSameTree(p.right, q.right);
            if (testLewy && testWart && testPrawy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            TreeNode tree1 = new TreeNode();
            tree1.left = new TreeNode(1);
            tree1.right = new TreeNode(2);

            TreeNode tree2 = new TreeNode();
            tree2.left = new TreeNode(1);
            tree2.right = new TreeNode(2);
            
            tree2.right.right = new TreeNode(3); // Wystarczy zakomentowac ten element by drzewa byly identyczne

            Console.WriteLine("Wynik testu czy drzewa sa takie same: " + IsSameTree(tree1, tree2));
        }
    }
}
