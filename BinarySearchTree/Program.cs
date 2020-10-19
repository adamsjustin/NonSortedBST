using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            int insertionSize = 100;
            int i = 0;
            while(i < insertionSize)
            {
                Random _random = new Random();
                bst.insert(_random.Next(0, 1000));
                i++;
            }
            Console.WriteLine(bst.printTreeHeight());
            Console.WriteLine(bst.search(15));
            Console.ReadKey();
        }
    }
}
