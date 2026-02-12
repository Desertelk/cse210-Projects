using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name,  description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in...\n");
            ShowCountDown(4);
            Console.Write("Breathe out...\n");
            ShowCountDown(6);
            elapsed += 10;
        }

        DisplayEndingMessage();
    }
}