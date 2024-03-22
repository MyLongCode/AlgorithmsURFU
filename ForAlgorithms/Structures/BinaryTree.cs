using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithms.Structures
{
    
    public class BinaryTree
    {
        public Node root;
        public class Node
        {
            public int key;
            public Node left;
            public Node right;
            
            public Node(int key)
            {
                this.key = key;
                left = null;
                right = null;
            }
        }
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int key)
        {
            Insert(root, key);
        }

        private Node Insert(Node x, int key)
        {
            if (root == null) root = new Node(key);
            if (key < x.key) x.left = Insert(x.left, key);
            else if (key > x.key) x.right = Insert(x.right, key);
            return root;
        }
    }
}
