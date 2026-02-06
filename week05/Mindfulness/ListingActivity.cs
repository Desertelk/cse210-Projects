public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity (string name, string description, int duration, int count, List<string> prompts)
        : base(name, description, duration)
    {
        this._count = count;
        this._prompts = new List<string>();
    }

    public void Run()
    {
        
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}