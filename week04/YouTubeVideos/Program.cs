using System;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments1 = new List<Comment>();
        Comment c1 = new Comment();
        c1._name = "Enssah";
        c1._text = "That's a cute Cat";
        comments1.Add(c1);

        Comment c2 = new Comment();
        c2._name = "Zofia";
        c2._text = "What's the cat's name?";
        comments1.Add(c2);

        Comment c3 = new Comment();
        c3._name = "Donald";
        c3._text = "My cat's name is pepper flakes";
        comments1.Add(c3);

        Comment c4 = new Comment();
        c4._name = "Bobby";
        c4._text = "Is it because it likes spicy food?";
        comments1.Add(c4);

        Video v1 = new Video("My Cat", "Donald", 30, comments1);
        int count = v1.NumberOfComments();
        v1.Display();
        Console.WriteLine($"There are {count} comments in this video");

        List<Comment> comments2 = new List<Comment>();
        Comment c5 = new Comment();
        c5._name = "Bobby";
        c5._text = "That's an awesome trick! Can you make a tutorial?";
        Comment c6 = new Comment();
        c6._name = "Mat";
        c6._text = "I used to do a ton of these when i was younger, my knees aren't the same anymore ;-;";
        Comment c7 = new Comment();
        c7._name = "Julie";
        c7._text = "I love watching my boyfriend do these <3";
        Comment c8 = new Comment();
        c8._name = "Grumpy";
        c8._text = "You better not do this on my lawn! >:(";
        comments2.Add(c5);
        comments2.Add(c6);
        comments2.Add(c7);
        comments2.Add(c8);

        Video v2 = new Video("Hardest Skateboard Ticks", "Tony Hawk", 120, comments2);
        v2.Display();
        int count2 = v2.NumberOfComments();
        Console.WriteLine($"There are {count2} comments in this vido");
    }
}