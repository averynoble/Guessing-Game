using System;
using System.Collections.Generic;

namespace Guessinggame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a difficulty: 1 - Easy, 2 - Medium, 3 - Hard");

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 100);
            
            int difficulty = int.Parse(Console.ReadLine());
            var difficulties = new List<int>
            {
                7, 5, 3
            };
            int guesses = difficulties[difficulty - 1];
                
            Console.WriteLine("Please guess the secret number!");

            Console.Write("Your guess ");
            int userGuess = int.Parse(Console.ReadLine());

            for (int i = 0; i < guesses; i++)
            {
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("You got it right! Great Job!");
                    return;
                }
                else 
                {
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("You guessed lower than the secret number");
                        Console.WriteLine($"You have ({guesses - i}) more chances. Please try again");
                        userGuess = int.Parse(Console.ReadLine());     
                    }
                    else
                    {
                        Console.WriteLine("You guessed higher than the secret number");
                        Console.WriteLine($"You have ({guesses - i}) more chances. Please try again");
                        userGuess = int.Parse(Console.ReadLine());    
                    }
                }
            }
            Console.WriteLine("You lost please try again");
            Console.WriteLine($"The correct number was {secretNumber}");
        }
    }
}
