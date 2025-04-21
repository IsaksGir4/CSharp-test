using System;
using System.Collections.Generic;

namespace SymmetricTree
{
    class Nodes
    {
        public int Value;
        public Nodes Left;
        public Nodes Right;

        public Nodes(int Value)
        {
            this.Value= Value;
            Left=null;
            Right=null;
        }
    }

    class SymmetricChech
    {
        static void Main(string[] args)
        {
            Nodes root = new Nodes(1);
            root.Left = new Nodes(2);
            root.Right = new Nodes(6);
            root.Left.Left = new Nodes(3);
            root.Left.Right = new Nodes(4);
            root.Right.Left = new Nodes(4);
            root.Right.Right = new Nodes(3);

            bool result = IsSymmetric(root);
            Console.WriteLine("Is symmetric? " + result);
        }

        static bool IsSymmetric(Nodes root)
        {
            if(root == null)
                return true;

            return IsMirror(root.Left,root.Right);
        }

        static bool IsMirror(Nodes t1, Nodes t2)
        {
            if(t1==null && t2 ==null)
                return true;

            if(t1==null || t2 ==null)
                return false;
            
            return (t1.Value ==t2.Value) && IsMirror(t1.Left,t2.Right) && IsMirror(t1.Right,t2.Left);
        }
    }
}