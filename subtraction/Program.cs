using System;

namespace subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            Console.WriteLine("Please enter the first number");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            secondNumber = int.Parse(Console.ReadLine());
            result = firstNumber - secondNumber;
            Console.WriteLine("The result of the subtraction of the two numbers is: "+ result);
        }
    }
}
