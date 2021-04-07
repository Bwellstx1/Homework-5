using System;
using System.IO;

namespace Homework_5
{
    class Arrays
    {
        private static double[] Main(string[] args)
        {
            string[] CustomernNames = new string[1000];
            double[] AccountBalances = new double[1000]; 

            string[] nameLines = File.ReadAllLines("CustomerNames.csv");
            string[] balancesLines = File.ReadAllLines("AccountBalances.csv");

            for(int i=1; i < nameLines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(nameLines[i]) == true)
                {
                    continue;
                }
                
                
                    CustomernNames[i - 1] = nameLines[i];

                    string balance = balancesLines[i];
                    balance = balance.Replace("$", "");
                    AccountBalances[i - 1] = Convert.ToDouble(balance);
                
            }
            Console.WriteLine("WHose account do you want to look up?");
            foreach (string name in CustomernNames)
            {
                Console.WriteLine(name);
            }
            string answer = Console.ReadLine();

            for (int i = 0; i < CustomernNames.Length; i++)
            {
                if (answer.ToLower() == CustomernNames[i].ToLower())
                {
                    Console.WriteLine($"{answer} has a balance of {AccountBalances[i].ToString("C")}!");
                }
            }
        }
    }
}
