public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity (string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name, description, duration)
    {
        this._prompts = new List<string>();
        this._questions = new List<string>();
    }

    public void Run()
    {
        
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {
        
    }
}