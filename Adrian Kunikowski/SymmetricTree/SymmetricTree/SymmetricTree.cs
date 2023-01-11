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

        static public bool IsSymmetric(TreeNode node1)
        {
            return IsSymmetric2(node1, node1);
        }

        static public bool IsSymmetric2(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 != null)
            {
                return false;
            }
            else if (node1 != null && node2 == null)
            {
                return false;
            }
            else if (node1 == null && node2 == null)
            {
                return true;
            }

            bool testLewy = IsSymmetric2(node1.left, node2.right);
            bool testWart = false;
            if (node1.val == node2.val)
            {
                testWart = true;
            }
            bool testPrawy = IsSymmetric2(node1.right, node2.left);
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
            tree1.left = new TreeNode(2);
            tree1.right = new TreeNode(2);
            tree1.left.left = new TreeNode(1);
            tree1.right.right = new TreeNode(5); // Wystarczy zmienic wartosc na "1" by drzewa byly symetryczne


            Console.WriteLine("Wynik testu czy drzewa sa symetryczne: " + IsSymmetric(tree1));
        }
    }
}
