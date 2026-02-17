using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Goals!");
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}