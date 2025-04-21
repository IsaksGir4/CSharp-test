using System;
using System.Collections.Generic;

namespace UniqueWords
{
    class Unique
    {
        static void Main(string[] args)
        {
            string[] words = {"hola", "casa", "perro", "luz"};

            List<string> result = FilterUniqueWords(words);

            Console.WriteLine("Words with unique letters: ");
            foreach(string word in result)
            {
                Console.WriteLine(word);
            }
        }

        static List<string> FilterUniqueWords(string[] words)
        {
            List<string> uniques= new List<string>();

            foreach(String word in words)
            {
                HashSet<char> letters = new HashSet<char>();
                bool repeat = false;

                foreach(char c in word)
                {
                    if(letters.Contains(c))
                    {
                        repeat=true;
                        break;
                    }
                    letters.Add(c);
                }

                if(!repeat)
                {
                    uniques.Add(word);
                }
            }
            return uniques;
        }
    }
}