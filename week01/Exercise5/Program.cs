using System;

class Program
{
    static String userIn;
    static void Main(string[] args)
    {
        DisplayMessage();
        String userName = PromptUserName();
        int userNum = PromptUserNumber();
        int numSquared = SquareNumber(userNum);
        DisplayResult(userName, numSquared);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.Write("What is your name: ");
        String userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        userIn = Console.ReadLine();
        int favNumber = int.Parse(userIn);
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(String name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}