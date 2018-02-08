using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = { "Boat", "house", "cat", "river", "cupboard" };
            Console.WriteLine("plurals of all words :");
            foreach (string mean in words) { Console.WriteLine(mean + "s"); }
            Console.WriteLine("");

            words[1] = "home";
            Console.WriteLine("Replace the 2nd word, with its synonym and print=");
            foreach (string mean in words) { Console.WriteLine(mean); }
            Console.WriteLine("");

            ArrayList lst = new ArrayList(words);
            lst.Add("Harsh");
            Console.WriteLine("After Adding a new word to the array list");
            Console.WriteLine("Length=" + lst.Count);
            Console.WriteLine("");

            Console.WriteLine("the list of words which contains the length of characters as 7:");
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Length == 7)
                {
                    Console.WriteLine("word is present"+words[j]);
                }
                else { Console.WriteLine("word is not present of size 7 in array"); }
            }
                Console.WriteLine("");

            Console.WriteLine("the word on 3rd position :" + words[2]);
            Console.WriteLine("");

            Array.Sort(words);
            Console.WriteLine("Sorted Array: ");

            foreach (String i in words)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("the reverse of an array :");
            for (int i = 0; i < words.Length / 2; i++)
            {
                string tmp = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = tmp;

            }
            for (int i = 0; i < words.Length; i++) { Console.WriteLine(words[i]); }
        }
    }
}
