// responsibility to track the title, author, and length

// each video has responsibility to store list of comments 
// & should have a method to return number of comments

using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void listComments()
    {
        // add a different color for each section of the output so it is easier to read
        // & to distinguish the different items on the output

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Video Title: {_title}");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Video Author: {_author}");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Video Length: {_length} seconds");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Number of Comments: {_comments.Count}");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Comments: ");

        Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Comment comment in _comments)
            {
                comment.DisplayComment();
            }
    }
}