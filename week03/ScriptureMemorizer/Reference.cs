// Keeps track of the book, chapter, and verse information.

using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _bookText;

    
    
    public void SetReffernce(string bookNmae, int chapter,int startVerse, int endVerse)
    {
        _book = bookNmae;
        _chapter= chapter;
        _verse= startVerse;
        _endVerse = endVerse;

    }
  
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return _book + " " + _chapter + ":" + _verse;
        }
        else
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
    }   
    public void Text(string text)
    {
        _book =text;

    }

    public string DixplayText()
    {
        return _bookText;
    }



}