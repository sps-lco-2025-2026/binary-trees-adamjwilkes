using System.Diagnostics;
using BinaryTrees;

namespace TestProject1;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestSum()
    {
        BinaryTree bt = new BinaryTree();
        bt.Insert(4);
        bt.Insert(5);
        bt.Insert(3);
        Debug.Assert(bt.sum() == 12);
    }
    [TestMethod]
    public void TestPresent()
    {
        BinaryTree bt = new BinaryTree();
        bt.Insert(5);
        bt.Insert(9);
        Debug.Assert(bt.Present(5) == true);
        Debug.Assert(bt.Present(59) == false);
    }
    [TestMethod]
    public void TestDuplicate()
    {
        BinaryTree bt = new BinaryTree();
        bt.Insert(5);
        bt.Insert(25);
        bt.Insert(4);
        Debug.Assert(bt.Duplicate() == false);
        bt.Insert(25);
        Debug.Assert(bt.Duplicate() == true);
    }
    [TestMethod]
    public void TestDepth()
    {
        BinaryTree bt = new BinaryTree();
        bt.Insert(5);
        bt.Insert(3);
        bt.Insert(4);
        bt.Insert(3);
        bt.Insert(3);
        bt.Insert(7);
        Debug.Assert(bt.depth() == 5);
    }
    [TestMethod]
    public void TestBalanced()
    {
        BinaryTree bt = new BinaryTree();
        bt.Insert(5);
        bt.Insert(3);
        bt.Insert(7);
        bt.Insert(8);
        Debug.Assert(bt.IsBalanced() == true);
        bt.Insert(9);
        Debug.Assert(bt.IsBalanced() == false);
    }
}
