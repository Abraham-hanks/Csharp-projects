using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age =0;
            Console.Write("Welcome to Hanks bar, how old are you? ");
            age = int.Parse(Console.ReadLine());

            if(age >= 18){
                Console.WriteLine("You are old enough to drink here, come on in! :)");
            }
            else if (age < 11){
                Console.WriteLine("You're too young to drink, we will contact your parents to come take you");
            }
            else{
                Console.WriteLine("You're too young to drink, please leave");
            }
        }
    }
}
