using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int holder = 0;
            Console.WriteLine("Guess a number");
            guess = int.Parse(Console.ReadLine());
            if (guess == holder)
            {
                Console.WriteLine("You got it right");
            }
            else{
                Console.WriteLine("That was wrong");
                Console.WriteLine("Welcome to the Guessing game.");
                Console.WriteLine("There are 3 levels, easy, medium and hard");
                Console.WriteLine("Easy: You get a chance to guess a number between 1 - 10, and get 6 guesses");
                Console.WriteLine("Medium: You get a chance to guess a number between 1 - 20, and get 4 guesses");
                Console.WriteLine("Hard: You get a chance to guess a number between 1 - 50, and only get 3 guesses");
                Console.WriteLine("Enter 1 for easy, 2 for medium and 3 for hard");
                int level = int.Parse(Console.ReadLine());
                if (level == 1)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        Random r = new Random();
                        int answer = r.Next(1,11);
                        Console.WriteLine("Guess a number");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == answer)
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else if (guess != answer )
                        {
                            Console.WriteLine("That was wrong");
                            if (i == 5)
                            {
                                Console.WriteLine("Game over!");
                                Console.WriteLine("The answer is: " + answer);
                            }
                        }
                    }
                }
                else if (level == 2)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Random r = new Random();
                        int answer = r.Next(1,21);
                        Console.WriteLine("Guess a number");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == answer)
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else if (guess != answer )
                        {
                            Console.WriteLine("That was wrong");
                            if (i == 3)
                            {
                                Console.WriteLine("Game over!");
                                Console.WriteLine("The answer is: " + answer);
                            }
                        }
                    }
                }
                else if (level == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Random r = new Random();
                        int answer = r.Next(1,51);
                        Console.WriteLine("Guess a number");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == answer)
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else if (guess != answer )
                        {
                            Console.WriteLine("That was wrong");
                            if (i == 2)
                            {
                                Console.WriteLine("Game over!");
                                Console.WriteLine("The answer is: "+ answer);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }
    }
}
