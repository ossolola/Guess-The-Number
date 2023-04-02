using System;

namespace guessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random Number
            int theNumber = new Random().Next(20);

            // Intro
            Console.WriteLine("Let's Play 'Guess the Number'! ");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // parameters
            int guessCount = 0;
            int guess;

            // Logic
            do
            {
                // Get guess from input
                Console.WriteLine("What's your guess?");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == -1)
                {
                    Console.WriteLine($"You Gave up!! Well I was thinking of the number {theNumber}");
                    break;
                } 
                else {
                    if (guess.GetType() != typeof(int))
                    {
                        guessCount++;
                        Console.WriteLine("Hmm, that doesn't look like a number. Try again.");
                        
                    } 
                    else if (guess < theNumber)
                    {
                        guessCount++;
                        Console.WriteLine("Nope, higher than that.");
                        
                    }
                    else if(guess > theNumber)
                    {
                        guessCount++;
                        Console.WriteLine("Nope, lower than that.");
                        
                    }
                }
            } while (guess != theNumber);

            // If true
            if(guess == theNumber)
            {
                guessCount++;
                Console.WriteLine($"You got it in {guessCount} guessess");
            }  

        }
    }
}