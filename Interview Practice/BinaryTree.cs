using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class BinaryTree
    {
        public TreeNode root;

        public BinaryTree()
        {
            this.root = null;
        }

        public void Insert(int value)
        {
            if (root == null)
            {
                this.root = new TreeNode(value);
            }
            else
            {
                InsertRecursive(this.root, value);
            }
        }

        private void InsertRecursive(TreeNode node, int value)
        {
            if (node.value > value)
            {//need to insert in the left brach 
                if (node.left != null)
                {
                    InsertRecursive(node.left, value);
                }
                else
                {
                    node.left = new TreeNode(value);
                }
            }
            else
            {//need to insert in the right branch 
                if (node.right != null)
                {
                    InsertRecursive(node.right, value);
                }
                else
                {
                    node.right = new TreeNode(value);
                }
            }
        }

        public String PreOrder()
        {
            String result = PreOrderRecursive(this.root);

            return result;
        }

        private String PreOrderRecursive(TreeNode node)
        {
            String result = node.value + " ";

            if (node.left != null)
                result += PreOrderRecursive(node.left);
            if (node.right != null)
                result += PreOrderRecursive(node.right);

            return result;
        }


        public String PostOrder()
        {
            String result = PostOrderRecursive(this.root);

            return result;
        }

        private String PostOrderRecursive(TreeNode node)
        {
            String result = "";

            if (node.left != null)
                result += PostOrderRecursive(node.left);
            if (node.right != null)
                result += PostOrderRecursive(node.right);

            result += node.value + " ";

            return result;
        }


        public String InOrder()
        {
            String result = PostOrderRecursive(this.root);

            return result;
        }

        private String InOrderRecursive(TreeNode node)
        {
            String result = "";

            if (node.left != null)
                result += InOrderRecursive(node.left);

            result += node.value + " ";

            if (node.right != null)
                result += InOrderRecursive(node.right);

            return result;
        }



        public void TreeToList()
        {
            TreeNode prev = null;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(this.root);

            while (q.Count > 1)
            {//until the queue is empty
                TreeNode curr = q.Dequeue();

                if (curr.left != null)
                {//check for left child
                    q.Enqueue(curr.left) ;
                }

                if (curr.right != null)
                {//check for right child
                    q.Enqueue(curr.right);
                }

                //remove the pointers
                curr.left = null;
                curr.right = null;

                if (prev != null)
                {//there is a previous node to link 
                    prev.right = curr;
                }

                prev = curr;//for next iteration prev
            }
        }

        public int GetHeigth()
        {
            return GetHeigthR(this.root);
        }

        public int GetHeigthR(TreeNode node)
        {
            int leftHeigth = 1;//current node
            int rightHeigth = 1;//current node

            if (node.left != null)
            { 
                leftHeigth = GetHeigthR(node.left);
            }
            if (node.right != null)
            {
                rightHeigth = GetHeigthR(node.right);
            }

            return Math.Max(leftHeigth, rightHeigth);
        }

        public int NumLeafNodes()
        {
            return NumLeafNodesR(this.root);
        }

        public int NumLeafNodesR(TreeNode node)
        {
            int numLeafNodes = 0;
            if (node.left == null && node.right == null)
            {
                //this is a leaf node
                return 1;
            }

            if (node.left != null)
            {
                numLeafNodes = NumLeafNodesR(node.left);
            }

            if (node.right != null)
            {
                numLeafNodes += NumLeafNodesR(node.left);
            }

            return numLeafNodes;
        }

    }

    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
