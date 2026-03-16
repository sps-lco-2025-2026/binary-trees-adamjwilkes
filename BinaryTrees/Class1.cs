using System.Security.Cryptography.X509Certificates;

namespace BinaryTrees;

public class BinaryTree
{
    Node root;
    public void Insert(int v)
    {
        if (root == null)
        {
            root = new Node(v);
        }
        else
        {
            root.Insert(v);
        }
    }
    public bool Present(int v)
    {
        if (root == null)
        {
            return false;
        }
        else
        {
            return root.Present(v);
        }
    }
    public int sum()
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            return root.sum();
        }
    }
    public bool Duplicate()
    {
        if (root == null)
        {
            return false;
        }
        else
        {
            return root.Duplicate();
        }
    }
    public int depth()
    {
        if (root == null)
        {
            return 0;
        }
        return root.depth(1);
    }
    public bool IsBalanced()
    {
        if (root == null)
        {
            return true;
        }
        return root.IsBalanced();
    }

}

internal class Node
{
    int _value;
    Node _left;
    Node _right;
    internal Node(int v)
    {
        _value = v;
        _left = null;
        _right = null;
    }
    internal void Insert(int v)
    {
        if (_value <= v)
        {
            if (_right == null)
            {
                _right = new Node(v);
                return;
            }
            _right.Insert(v);
            return;
        }
        if (_left == null)
        {
            _left = new Node(v);
            return;
        }
        _left.Insert(v);
    }
    internal bool Present(int v)
    {
        if (_value == v)
        {
            return true;
        }
        if( _value > v)
        {
            if (_left != null)
            {
                return _left.Present(v);
            }
            return false;
        }
        if (_right != null)
        {
            return _right.Present(v);
        }
        return false;
    }
    internal int sum()
    {
       int sum = _value;
        if (_left != null)
        {
            sum += _left.sum();
        }
        if (_right != null)
        {
            sum += _right.sum();
        }
        return sum;
    }

    internal bool Duplicate()
    {
        if (this.DuplicateInt(this._value) == true)
        {
            return true;
        }
        if (_left.Duplicate != null)
        {
            if (_left.DuplicateInt(_left._value) == true)
            {
                return true;
            }
        }
        if (_right.Duplicate != null)
        {
            if (_right.DuplicateInt(_right._value) == true)
            {
                return true;
            }
        }
        return false;
    }
    internal bool DuplicateInt(int v)
    {
        if (_left != null)
        {
            if (_left._value == v)
            {
                return true;
            }
            return _left.DuplicateInt(v);
        }
        if (_right != null)
        {
            if (_right._value == v)
            {
                return true;
            }
            return _right.DuplicateInt(v);
        }
        return false;
    }
    internal int depth(int v)
    {
        if (_right == null)
        {
            if (_left == null)
            {
                return v;
            }
            return _left.depth(v+1);
        }
        if (_left == null)
        {
            return _right.depth(v+1);
        }            

        if (_right.depth(v+1)>_left.depth(v+1))
        {
            return _right.depth(v+1);
        }
        return _left.depth(v+1);
        
    }
    internal bool IsBalanced()
    {
        if (_right != null && _left != null)
        {
            return (_right.IsBalanced() && _left.IsBalanced());
        }
        if (_right == null && _left != null)
        {
            if (_left.depth(1)>= 2)
            {
                return false;
            }
        }
        if (_left == null && _right != null)
        {
            if (_right.depth(1)>= 2)
            {
                return false;
            }
        }
        return true;
    }
}