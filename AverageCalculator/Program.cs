using System.Collections.Generic;
using System;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int average = 0;
            int low = 0;
            int high = 0;
            int[] array = new int[2];
            List<int> inbetweeners = new List<int>();
            Console.WriteLine("Hi, I'm an Average calculator");
            Console.WriteLine("I return the average of 2 integers and a list of all the numbers between them");
            Console.Write("Please enter the first number:");
            array[0] = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            array[1] = int.Parse(Console.ReadLine());

            average = (array[0] + array[1])/2;
            if(array[0] > array[1]){
                low = array[1];
                high = array[0];
            }
            else{
                low = array[0];
                high = array[1];
            }
            int nextNumber = low;
            for(int i = low + 1; i < high; i++){
                nextNumber = nextNumber + 1;
                inbetweeners.Add(nextNumber); 
            }
            Console.WriteLine("The average is "+ average);
            Console.WriteLine("The integers between them:");
            inbetweeners.ForEach(el => Console.WriteLine(el));
        }
    }
}