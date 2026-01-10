using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me your first name:");
        String fname = Console.ReadLine();

        Console.WriteLine("Give me your last name: ");
        String lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");

    }
}