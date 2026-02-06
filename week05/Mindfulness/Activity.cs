public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description, int duration){
        this._name = name;
        this._description = description;
        this._duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        
    }

    public void ShowSpinner(int seconds) 
    {

    }

    public void ShowCountDown(int seconds)
    {
        
    }
}