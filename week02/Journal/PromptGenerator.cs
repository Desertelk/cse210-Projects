using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What challange did I overcome today, and how did I do it?",
        "What moment today made me stop and think the most?",
        "What is something small that I am grateful for today?",
        "When did I feel the most at peace today, and why?",
        "What did I learn about myself today?"
    };

    public string getRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}