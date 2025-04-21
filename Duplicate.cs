using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Duplicate
    {
        static void Main(string[] args)
        {
            //Input example
            List<string> input = new List<string> {"apple","banana","apple","orange","banana"};

            List<string> result = RemoveDuplicatesLastChance(input);

            Console.WriteLine("Result after remove duplicate: ");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> RemoveDuplicatesLastChance(List<string> entry)
        {
            HashSet<string> views = new HashSet<string>();
            List<string> resultInverse = new List<string>();

            for(int i = entry.Count-1;i>=0;i--)
            {
                string actual = entry[i];

                if(!views.Contains(actual))
                {
                    views.Add(actual);
                    resultInverse.Add(actual);
                }
            }

            resultInverse.Reverse();
            return resultInverse;
        }
    }
}