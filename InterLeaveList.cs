using System;
using System.Collections;
using System.Collections.Generic;

namespace InterLeaveList
{
    class InterLeave
    {
        static void Main(string [] args)
        {
            List<object> list1 = new List<object> {1,2,3,4,5};

            List<object> list2 = new List<object> {'a', 'b', 'c'};
            
            List<object> result = IntercalateList(list1,list2);

            Console.WriteLine("Result of Intercalate lists: ");
            foreach(var item in result)
            {
                Console.Write(item + " ");
            }
        }

        static List<object> IntercalateList(List<object> list1, List<object> list2)
        {
            List<object> result = new List<object>();
            int maxLenght = Math.Max(list1.Count, list2.Count);

            for(int i=0;i<maxLenght; i++)
            {
                if(i<list1.Count)
                    result.Add(list1[i]);
                
                if(i<list2.Count)
                    result.Add(list2[i]);

            }

            return result;
        }
    }
}