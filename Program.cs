using System;

namespace Guess
{
    class Program
    {
        static void Main (string[] args)
        {
            int guess = 0;
            int random = Random.Shared.Next (1, 101);
            
            Console.WriteLine ("Welcome to Number Guessing Game!");
        while(guess != random)
            {
            Console.Write ("Please guess the number(1-100): ");

            if (int.TryParse(Console.ReadLine(), out guess)){
                if (guess > random)
                    {
                        Console.WriteLine ("Bot: Lower!");
                    }
                    else if (guess < random)
                    {
                        Console.WriteLine ("Bot: Higher!");
                    }
                    else if (guess == random)
                    {
                        Console.WriteLine ("Bot: " + guess + " is the number!");
                    }
            }
            else
            {
                Console.WriteLine ("Bot: Invalid");
            }
        }
        }
    }
}