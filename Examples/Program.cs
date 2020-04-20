using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.ReadKey();

            // int number;
            // Console.Write("Enter a number: ");
            // number = int.Parse(Console.ReadLine());
            // Console.WriteLine("You entered: {0}", number);

            // int num1, num2, sum;
            // Console.WriteLine("Calculate the sum of 2 numbers:");
            // Console.WriteLine("Input number 1:");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input number 2:");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // sum = num1 + num2;
            // Console.WriteLine("Result:" + sum);

            // float num1, num2, product;
            // Console.WriteLine("Calculate the product of 2 floating point numbers:");
            // Console.WriteLine("Input number 1:");
            // num1 = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Input number 2:");
            // num2 = Convert.ToSingle(Console.ReadLine());
            // product = num1 * num2;
            // Console.WriteLine("Result:" + product);

            // double r, perimeter, area;
            // Console.WriteLine("Please enter the radius of your circle: ");
            // r = Double.Parse(Console.ReadLine());
            // perimeter = 2 * Math.PI * r;
            // area = Math.PI * Math.Pow(r, 2);
            // Console.WriteLine("=============================================");
            // Console.WriteLine("The perimeter of yor circle : {0}",perimeter);
            // Console.WriteLine("The area of yor circle : {0}", area);
            // Console.ReadKey();

            string sentence;
            Console.Write("Enter String  : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words :"+words.Length);
            Console.WriteLine(words[0]);
            Console.ReadKey();

        }
    }
}
