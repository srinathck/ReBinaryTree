using System;

namespace BinaryTree
{
    public class Node<T> where T : IComparable<T>, IEquatable<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T val)
        {
            Value = val;
        }

        public bool HasTwoChildren()
        {
            if (Left != null && Right != null)
                return true;
            return false;
        }

        public bool HasOneChild()
        {
            if (Left != null ^ Right != null)
                return true;
            return false;
        }

        public bool HasNoChildren()
        {
            if (!HasTwoChildren() && !HasOneChild())
                return true;
            return false;
        }

        //Return limited to only childs
        public Node<T> Child()
        {
            if (HasOneChild())
            {
                if (Left != null) return Left;
                if (Right != null) return Right;
            }
            return null;
        }
    }
}