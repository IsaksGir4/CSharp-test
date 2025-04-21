using System;
using System.Collections.Generic;

namespace SummaryOfRanges
{
    class Ranges{
        static void Main(string[] args)
        {
            //Input example
            List<int> numbers = new List<int> {0,1,2,3,4,5,6,7,10,11,12};

            //Call the function that resume the ranges
            List<string> result = ResumeRanges(numbers);

            Console.WriteLine("Ranges resume: ");
            foreach(var range in result)
            {
                Console.WriteLine(range);
            }
        }

        //Resume all ranges consecutives in one list ordered on ints
        static List<string> ResumeRanges(List<int> numbers)
        {
            List<string> ranges = new List<string>();

            if(numbers.Count == 0)
            return ranges;

            int init = numbers [0];

            for (int i=1; i<=numbers.Count; i++)
            {
                if (i==numbers.Count || numbers[i] != numbers[i-1] + 1)
                {
                    int end = numbers[i-1];

                    if(init == end)
                        ranges.Add(init.ToString());
                    else
                        ranges.Add(init + "->" + end);

                    //Update the start of the next range
                    if(i<numbers.Count)
                        init= numbers[i];
                }
            }

            return ranges;
        }
    }
}