using System.ComponentModel;
using System.Collections.Generic;

public class Video
{
    string _title;
    string _author;
    int _duration;
    List<Comment> _comments;

    public Video (string title, string author, int duration, List<Comment> comments) {
        this._title = title;
        this._author = author;
        this._duration = duration;
        _comments = comments;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title} - Author: {_author} - Duration: {_duration} seconds");
        Console.WriteLine($"Comments: ");
        foreach (Comment c in _comments)
        {
            c.Display();
        }
    }

    public int NumberOfComments()
    {
        int counter = 0;
        foreach (Comment c in _comments){
            counter++;
        }
        return counter;
    }
}