using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace FrecuencyWords
{
    class Frecuency
    {
        static void Main(string[] args)
        {
            string pharagraph = ("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus finibus ante mauris, eget facilisis purus finibus ut. Etiam dictum lacus et pulvinar sollicitudin. Fusce sed feugiat est. Nam nunc velit, rutrum id justo et, ullamcorper dignissim tellus. Morbi aliquet erat at egestas dapibus. Ut semper vulputate ligula, eget euismod est interdum eu. Nullam consequat nulla ligula, eget lacinia nisi fringilla et. Ut accumsan fringilla pulvinar. Nullam dolor leo, interdum nec lorem ut, vulputate mattis dui. Sed et purus mauris. Pellentesque sed purus eget dolor malesuada semper. Nulla commodo quam nibh. Aenean quis urna id velit egestas imperdiet et et ante. Suspendisse velit felis, rhoncus eget scelerisque eu, volutpat eu velit. Aliquam vel metus eleifend, lobortis ex vitae, hendrerit nunc. Quisque pretium nulla dictum, fringilla magna nec, dapibus diam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque egestas semper viverra. Etiam at risus a mauris pretium sodales. Mauris aliquet ipsum nulla. Quisque leo mauris, scelerisque sed mi eget, scelerisque ornare lorem. Vivamus imperdiet dolor et felis iaculis, elementum varius est dignissim. Nunc felis erat, pulvinar id velit eget, ultricies iaculis mauris. Nunc euismod, metus id suscipit bibendum, urna turpis tempor arcu, sit amet malesuada tortor leo ut leo. Suspendisse sem odio, tristique a felis et, maximus pulvinar neque.");

            List<(string word, int frecuency)> result = FrecuencyCount(pharagraph);

            Console.WriteLine("Ordered words by frecuency");

            foreach(var par in result)
            {
                Console.WriteLine($"(\"{par.word}\",{par.frecuency}");
            }
        }

        static List<(string word, int frecuency)> FrecuencyCount(string text)
        {
            text=text.ToLower();
            text= Regex.Replace(text, @"[.,;:!?]","");
            string[] words = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,int> count = new Dictionary<string, int>();
            foreach(String word in words)
            {
                if(count.ContainsKey(word))
                    count[word]++;
                else
                    count[word] =1;
            }
            var result=count.OrderByDescending(p=>p.Value).Select(p => (p.Key,p.Value)).ToList();

            return result;
        }
    }
}