using System.ComponentModel;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random rand = new Random();

    public ListingActivity (string name, string description, List<string> prompts)
        : base(name, description)
    {
        this._prompts =  prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }
        return items;
    }
}