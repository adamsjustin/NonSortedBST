using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public void insert(int value)
        {
            if(this.root == null)
            {
                this.root = new Node(value);
            }
            else
            {
                this._insert(value, this.root);
            }
        }

        private void _insert(int value, Node cur_node)
        {
            if(value < cur_node.getValue())
            {
                if (cur_node.getLeftNode() == null)
                {
                    cur_node.setLeftNode(new Node(value));
                }
                else
                {
                    this._insert(value, cur_node.getLeftNode());
                }
            }
            else if (value > cur_node.getValue())
            {
                if (cur_node.getRightNode() == null)
                {
                    cur_node.setRightNode(new Node(value));
                }
                else
                {
                    this._insert(value, cur_node.getRightNode());
                }
            }
            else
            {
                Console.WriteLine("Value already exists in tree.");
            }
        }

        public void printTree()
        {
            if (this.root != null)
            {
                this._printTree(this.root);
            }
        }

        private void _printTree(Node cur_node)
        {
            if(cur_node != null)
            {
                Console.WriteLine(cur_node.getValue());
                _printTree(cur_node.getLeftNode());
                _printTree(cur_node.getRightNode());
            }
        }

        public int printTreeHeight()
        {
            if(this.root != null)
            {
                return this._printTreeHeight(this.root, 0);
            }
            else
            {
                return 0;
            }
        }

        private int _printTreeHeight(Node cur_node, int cur_height)
        {
            if (cur_node == null)
            {
                return cur_height;
            }
            int left_height = this._printTreeHeight(cur_node.getLeftNode(), cur_height + 1);
            int right_height = this._printTreeHeight(cur_node.getRightNode(), cur_height + 1);
            return Math.Max(left_height, right_height);
        }

        public bool search(int value)
        {
            if (this.root == null)
                return false;
            else
            {
                return this._search(this.root, value);
            }
        }

        private bool _search(Node cur_node, int value)
        {
            if(cur_node == null)
            {
                return false;
            }
            if (cur_node.getValue() == value)
            {
                return true;
            }
            else if (value < cur_node.getValue())
            {
                return this._search(cur_node.getLeftNode(), value);
            }
            else if(value > cur_node.getValue())
            {
                return this._search(cur_node.getRightNode(), value);
            }
            else
                return false;
        }
         
    }
}
