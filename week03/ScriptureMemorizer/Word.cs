// Keeps track of a single word and whether it is shown or hidden.

using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
        
        
        

    }
    

    public void Hide()
    {
        _isHidden = true;
    }
     
     public void Show()
     {
        _isHidden =false;
     }


     public bool IsHidden()
     {
          return _isHidden;
     }
     public string GetDisplayText()
     {
        if(_isHidden) {
            
           return  new string('_',_word.Length);

           }
        else{
                return _word;
            } 
             
     }
     


}