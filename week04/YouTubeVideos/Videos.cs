using System;


public class Videos
{
       public string _title;
       public string _author;
       public int _length;

       public List<Comment> _comments = new List<Comment>();


       public void AddComment(Comment comment)
       {
              _comments.Add(comment);
       }


       public int CommentCount()
       {
              return _comments.Count;
       }

       public void DisplayVideosDetails()
       {
              Console.WriteLine($"Title:{_title}");
              Console.WriteLine($"Authur:{_author}");
              Console.WriteLine($"Lenght:{_length}Secounds");
              Console.WriteLine($"Total Comment:{CommentCount()}");
             
              Console.WriteLine("Comment:");
              foreach(Comment Comment in _comments)
              {
                Comment.DisplayComment();
              }
       }

}