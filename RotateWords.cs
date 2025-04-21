using System;

namespace RotateWords
{
    class RotateWords
    {
        static void Main(String[] args)
        {
            //example input
            string phrase = "uno dos tres cuatro";
            int k = 3;

            Console.WriteLine("Example: ");
            Console.WriteLine(phrase);
            string result = RotateWordsFunction(phrase, k);
            Console.WriteLine("Result after rotate: ");
            Console.WriteLine(result);
        }
        static string RotateWordsFunction(string text, int k)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            string[] words = text.Split(' ');
            int n = words.Length;

            k =k % n;

            string[] rotates = new string[n];
            Array.Copy(words, n-k, rotates,0,k);
            Array.Copy(words,0,rotates,k,n-k);

            return string.Join(" ", rotates);
        }
    }
}