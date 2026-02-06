using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment m1 = new MathAssignment("Caden Watts", "Adv Calculus", "24a", "8-28");
        WritingAssignments w1 = new WritingAssignments("Zofi Watts", "Business Economics", "Best Eco Practices");

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeWorkList());
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}