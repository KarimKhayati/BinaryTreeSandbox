using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDepthCalc
{

    public class BinaryTree<T>
    {
        private Node _treeRoot;
        private int _nodesCount;

        public int NodeCount
        {
            get { return _nodesCount; }

        }

        public void AddNode(int value)
        {

            if (_treeRoot == null)  // The tree is empty - set the tree root
            {
                _treeRoot = new Node(value);
            }

            else  // The tree is not empty we need find the right node to insert into
            {
                AddToExistingNode(_treeRoot, value);
            }

            _nodesCount++;
        }


        private void AddToExistingNode(Node node, int value) // recursive
        {
            // Left Case
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);  // set it to the left node
                }
                else
                {
                    AddToExistingNode(node.Left, value);  // add  to the left
                }
            }
            // Right case 
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);  // set it to the right node
                }
                else
                {
                    AddToExistingNode(node.Right, value); // add to the right
                }
            }
        }

        public int ClaculateTreeDepth()
        {

            if (_treeRoot == null)
            {
                return 0;
            }

            else
            {
                return ClaculateTreeDepth(_treeRoot);
            }

        }

        private int ClaculateTreeDepth(Node node)
        {
            if (node == null)
                return 0;

            int leftNode = ClaculateTreeDepth(node.Left);
            int rightNode = ClaculateTreeDepth(node.Right);

            if (leftNode > rightNode)
                return leftNode + 1;
            else
                return rightNode + 1;
        }

    }






}
