using System;
using System.Collections.Generic;

namespace AnagramGrouping
{
    class Anagrams
    {
        static void Main(string[] args)
        {
            //Input from the work
            string[] input = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};

            // Call the function that group the anagrams
            List<List<string>> result = GroupAnagrams(input);

            Console.WriteLine("Anagrams Groups: ");
            foreach (var group in result)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", group));
                Console.WriteLine("]");
            }

        }

        //group words that are be anagrams each it
        static List<List<string>> GroupAnagrams(string[] words)
        {
             // key = alphabetically ordered word (anagram signature)
             // value = list of words that have that signature
            Dictionary<string, List<string>> AnagramsMaps = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                //Convert the word in an array of characters
                char[] letters = word.ToCharArray();
                Array.Sort(letters);

                string  key = new string(letters);
                
                // If the key
                if(!AnagramsMaps.ContainsKey(key))
                {
                    AnagramsMaps[key] = new List<string>();
                }
                
                AnagramsMaps[key].Add(word);

            }
            
            List<List<string>> groups = new List<List<string>>();
            foreach (var group in AnagramsMaps.Values)
            {
               groups.Add(group);
            }

            return groups;


        }

    }
}

