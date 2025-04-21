using System;

namespace SumLeavesTree
{
    class Nodes
    {
        public int Value;
        public Nodes Left;
        public Nodes Right;

        public Nodes(int value){
            Value = value;
            Left= null;
            Right = null;
        }

    }

    class LeavesTree
    {

        static void Main(string[] args)
        {
            Nodes branch = new Nodes(23);
            branch.Left=new Nodes(4);
            branch.Right=new Nodes(8);
            branch.Left.Left = new Nodes(7);
            branch.Left.Right = new Nodes(4);
            branch.Right.Right = new Nodes(10);
            int sum = SumLeaves(branch);
            Console.WriteLine("sum of the leaves:" +sum);
        }

        static int SumLeaves(Nodes node)
        {
            if(node == null)
                return 0;
            if(node.Left == null && node.Right == null)
                return node.Value;
            
            return SumLeaves(node.Left)+SumLeaves(node.Right);
        }
    }
}