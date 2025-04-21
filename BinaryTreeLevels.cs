using System;
using System.Collections.Generic;

namespace BinaryTreeLevels
{
    class Nodes
    {
        public int Value;
        public Nodes Left;
        public Nodes Right;

        public Nodes(int value)
        {
            Value = value;
            Left= null;
            Right = null;
        }
    }

    class TreeLevels
    {
        static void Main(string[] args)
        {
            Nodes root = new Nodes(1);
            root.Left = new Nodes(2);
            root.Right = new Nodes(3);
            root.Left.Left = new Nodes(4);
            root.Left.Right = new Nodes(5);
            root.Right.Right = new Nodes(6);
            root.Right.Right.Left = new Nodes(7);

            List<List<int>> levels = GetLevels(root);

            foreach (var level in levels)
            {
                Console.WriteLine("[" + string.Join(",",level)+"]");
            }
        }

        static List<List<int>> GetLevels(Nodes root)
        {
            List<List<int>> result = new List<List<int>>();
            if(root == null)
                return result;
            
            Queue<(Nodes node, int level)> queue = new Queue<(Nodes, int)>();
            queue.Enqueue((root,0));

            while(queue.Count>0)
            {
                var(current, level) = queue.Dequeue();

                if(result.Count == level)
                {
                    result.Add(new List<int>());
                }

                result[level].Add(current.Value);

                if(current.Left != null)
                    queue.Enqueue((current.Left, level+1));
                if(current.Right != null)
                    queue.Enqueue((current.Right, level+1));
            }

            return result;
        }
    }
}