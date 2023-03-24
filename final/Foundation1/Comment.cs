// responsibility for tracking both name pf person who made the comment
// & the text of the comment

using System;

public class Comment
{
    public string _commenter;
    public string _comment;
    public void DisplayComment()
    {
        Console.WriteLine($"Name of the Commenter: {_commenter}, {_comment}");
    }
}