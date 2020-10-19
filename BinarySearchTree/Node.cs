using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node
    {
        private int value;
        private Node left_child;
        private Node right_child;
        public Node(int value)
        {
            this.value = value;
            this.left_child = null;
            this.right_child = null;
        }

        public int getValue()
        {
            return this.value;
        }
        public Node getLeftNode()
        {
            return this.left_child;
        }
        public Node getRightNode()
        {
            return this.right_child;
        }

        public void setValue(int value)
        {
            this.value = value;
        }
        public void setLeftNode(Node newNode)
        {
            this.left_child = newNode;
        }
        public void setRightNode(Node newNode)
        {
            this.right_child = newNode;
        }
    }
}
