using System;


public class Comment
{
    public string _name;
    public string _personComment;


    public void DisplayComment()
    {
        Console.WriteLine($"Name:{_name }");
        Console.WriteLine($"{_personComment}");
          Console.WriteLine($"");
        
    }
}