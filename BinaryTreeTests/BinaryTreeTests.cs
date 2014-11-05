using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTreeDepthCalc;


namespace BinaryTreeTests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void AddRoot_Test()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.AddNode(5);
            Assert.AreEqual(tree.NodeCount, 1);

        }


        [TestMethod]
        public void EmptyTree_DepthIsZero_Test()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            var treeHeight = tree.ClaculateTreeDepth();
            Assert.AreEqual(treeHeight, 0);

        }

        [TestMethod]
        public void TreeWithOneNode_DepthIsOne_Test()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.AddNode(7);
            var treeHeight = tree.ClaculateTreeDepth();
            Assert.AreEqual(treeHeight, 1);

        }

        [TestMethod]
        public void TreeWith4Level_DepthIsFour_Test()
        {
            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.AddNode(4);
            tree.AddNode(5);
            tree.AddNode(2);
            tree.AddNode(7);
            tree.AddNode(3);
            tree.AddNode(6);
            tree.AddNode(1);

            var treeHeight = tree.ClaculateTreeDepth();
            Assert.AreEqual(treeHeight, 4);

        }


        [TestMethod]
        public void TreeWith3Level_DepthIsThree_Test()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //     3
            //    /
            //   2
            //  /
            // 1

            tree.AddNode(3);
            tree.AddNode(2);
            tree.AddNode(1);

            var treeHeight = tree.ClaculateTreeDepth();
            Assert.AreEqual(treeHeight, 3);

        }
    }
}
