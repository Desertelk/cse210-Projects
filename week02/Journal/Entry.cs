public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public string toFileString()
    {
       return $"{Date} | {Prompt} | {Response}";
    }

    public static Entry fromFileString(string line)
    {
        string[] parts = line.Split(" | ");
        return new Entry(parts[0], parts[1], parts[2]);
    }
}