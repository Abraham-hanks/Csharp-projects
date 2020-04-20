using System;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0.0;
            int secondNumber = 0;
            double result = 0.0;

            Console.WriteLine("Please enter the first number");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            secondNumber = int.Parse(Console.ReadLine());
            result = firstNumber/secondNumber;
            Console.WriteLine("The result of the division of the two numbers is: "+ result);
        }
    }
}
