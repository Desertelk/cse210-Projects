using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        String userIn = "";
        
        while (userIn != "no")
        {
            
            Console.WriteLine("Guess the magic number!");
            Random random = new Random();
            int counter = 0;

            int magicNumber = random.Next(1, 101);
            int userGuess = -1;
            while (userGuess != magicNumber){
                
                Console.Write("What is your guess: ");
                userIn = Console.ReadLine();
                userGuess = int.Parse(userIn);

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed the magic number!");
                }

                counter++;
            }

            Console.WriteLine($"It took you {counter} tried to guess the number.");
            Console.Write("Would you like to play again? yes/no: ");
            userIn = Console.ReadLine();
        }
    }
}