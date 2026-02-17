using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");

        GoalManager gm = new GoalManager();
        gm.Start();

        Console.WriteLine("\nThanks for playing Eternal Quest!");
    }
}