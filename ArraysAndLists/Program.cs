using System.Linq;
using System.Collections.Generic;
using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] accountBalances = new int [5];
            accountBalances[0] = 1000;
            accountBalances[1] = 2000;
            accountBalances[2] = 5000000;
            accountBalances[3] = 100000;
            accountBalances[4] = 90000;

            int sum = accountBalances.Sum();

            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Pineapple");
            fruits.Add("orange");

            Console.WriteLine("$" + accountBalances[4]);
            Console.WriteLine("$" + sum);
            Console.WriteLine("I like " + fruits[0]);

        }
    }
}
