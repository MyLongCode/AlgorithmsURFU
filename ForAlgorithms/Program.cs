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
            tree.Insert(100);
            tree.Insert(50);
            tree.Insert(150);
            tree.Insert(125);
            tree.Insert(75);
            tree.Insert(74);
            tree.Insert(76);
            tree.Insert(124);
            tree.Insert(130);
            tree.Insert(131);
            tree.Traverse(tree.root);
        }
    }
        
}
