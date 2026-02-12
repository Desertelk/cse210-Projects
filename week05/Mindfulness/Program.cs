using System;

class Program
{
    static void Main(string[] args)
    {

        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "Who are people with whom you wish your relationship was better?",
            "Who are people that have helped you this week?",
            "What are things that you are proud of this week?",
            "What are things that you could have done better this week?"
        };

        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time that you have helped someone.",
            "Think of a time that you have overcome a challenge.",
            "Think of a time that you have been hurt and were able to forgive those who have hurt you.",
            "Think of a time that you did something selfless."
        };

        List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "What did you do to get started?",
            "What did you feel when you finished?",
            "What made this time different than other times?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        }; 

        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            String choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by clearing your mind through guided breathing.");
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This will give you prompts to reflect on and write about your feelings", reflectionPrompts, reflectionQuestions);
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you list several things that can help you recognize what you have and what you can do better.", listingPrompts);
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you! We await your return for another Mindful activity!");
                    return;
                default:
                    continue;
            }
        }
    }
}