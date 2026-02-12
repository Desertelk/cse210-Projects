public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random rand = new Random();
    public ReflectionActivity (string name, string description, List<string> prompts, List<string> questions)
        : base(name, description)
    {
        this._prompts = prompts;
        this._questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("Press Enter when ready.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine();
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
            Console.WriteLine();
            Console.WriteLine("Press Enter when ready.");
            Console.ReadLine();

        }
    }
}