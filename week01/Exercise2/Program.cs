using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input the grade you received: ");
        String userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        char letterGrade; 
        if (grade >= 90)
        {
            letterGrade = 'A';
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = 'B';
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = 'C';
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = 'D';
        }
        else
        {
            letterGrade = 'F';
        }

        if (grade >= 70)
        {
            Console.WriteLine($"You passed with a grade of {letterGrade}");
        }
        else
        {
            Console.WriteLine($"You got a {letterGrade} study more for the next one");
        }
    }
}