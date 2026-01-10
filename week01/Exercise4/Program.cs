using System;
using System.Transactions;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        String userIn;
        int userNumber = -1;
        List<int> numbers;
        numbers = new List<int>();
        int sum = 0;
        int smallestNum = int.MaxValue;
        

        Console.WriteLine("Eneter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userIn = Console.ReadLine();
            userNumber = int.Parse(userIn);
            if (userNumber == 0)
            {
                break;
            }
            numbers.Add(userNumber);
        }

        // Get the sum of all numbers in the list.
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of all numbers in list is {sum}");

        // Get the average of the numbers in the list
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers in list is {average}");

        // Get the max number in the list
        int max = numbers[0];

        foreach(int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number in the list is {max}");

        // Get the smallest positive integer in the list
        foreach(int num in numbers)
        {
            if (num < smallestNum && num > 0)
            {
                smallestNum = num;
            }    
        }
        Console.WriteLine($"The smalles positive number is {smallestNum}");
        
        //The sorted list.
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            
            Console.WriteLine(numbers[i]);
        }
    }
}