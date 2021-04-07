using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = File.ReadAllLines("Java Eyre.txt");

            Dictionary<string, int> wordCOunt = new Dictionary<string, int>();
            bool foundBeginningOfBook = false;

            foreach (string line in sentences)
            {
                if (line.Contains("CHAPTER 1") == true)
                {
                    foundBeginningOfBook = true;

                }

                if (foundBeginningOfBook == false
                    && string.IsNullOrWhiteSpace(line) == true)

                {
                    continue;
                }
                if (line.Contains("*** END OF THE PROJECT GUTENBURG EBOOK JANE EYRE***") == true)
                {
                    break;
                }

                string[] words = line.Split(" ");

                foreach (string word in words)
                {
                    char[] punctuation = { ',', '.', '!', '?', ';', '$', '"', };
                    string current = word.ToLower()Trim(punctuation);

                    if (wordCOunt.ContainsKey(word.ToLower()) == false)
                    {
                        wordCOunt.Add(word.ToLower(), 0);
                    }
                    wordCOunt[word.ToLower()] = wordCOunt[word.ToLower()] + 1;
                }
                Console.WriteLine("\nJane Eyre Dictionary");
                Console.WriteLine($"{"Word".PadRight(25, } \tCount);


                foreach (string word in wordCOunt.Keys)
                {
                    Console.WriteLine("${word}\t\t\t{wordCOunt[word].ToString("N0  }"); 
                }
            Console.WriteLine("Do you want to search for a specific word? yes or no?");
            string answer = Console.ReadLine();

            if (answer.ToLower()[0] = 'y')
            {
                Console.ReadLine("What is the word you are searching for?");
                answer = Console.ReadLine();
            }

























            }




            
        }
    }
}
