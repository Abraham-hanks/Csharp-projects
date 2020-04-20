using System.Collections.Generic;
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Abraham";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }

            string input = "";
            List<String> attendees = new List<string>();
            while( input != "end")
            {
                Console.WriteLine("Enter students name: ");
                input = Console.ReadLine();
                if(input == "end"){
                    break;
                }
                attendees.Add(input);
            }

            Console.WriteLine("\nAttendees entered succesfully, \nEntries are below:");
            for (int i = 0; i < attendees.Count; i++)
            {
                Console.WriteLine(attendees[i]);
                
            }
        }
    }
}
