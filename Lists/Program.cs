using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteItems = new List<string>();
            string answer;

            do
            {
                Console.WriteLine("What is your favorite thing that you want to add to the list?");
                answer = Console.ReadLine();
                favoriteItems.Add(answer);

                Console.WriteLine("Do you have another thing to add? Yes or no?");
                answer = Console.ReadLine();



            } while (answer.ToLower()[0] == 'y');

            Console.WriteLine("\n1) from top to bottom");
            foreach (string item in favoriteItems) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n2) from top to bottom");
            for (int i = favoriteItems.Count - 1; i < 0; i++)
            {
                Console.WriteLine(favoriteItems[i]);
            }

            Console.WriteLine("\n3) output every other entry in the list"); 
            for (int i = 0; i <favoriteItems.Count; i+=2)
            {
                Console.WriteLine("favoriteItems[i}");
            }

        }
    }

    internal class List<T>
    {
        internal int Count;

        public List()
        {
        }
    }
}
