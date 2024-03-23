using ForAlgorithms.Sorts;
using ForAlgorithms.Structures;
using System.Buffers.Binary;

namespace Algorithms
{
    class Algorithms
    {
        public static void Main()
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(7);
            tree.Insert(10);
            tree.Traverse(tree.root);
        }
    }
        
}
