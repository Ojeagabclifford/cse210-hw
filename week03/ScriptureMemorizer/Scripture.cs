// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words  = new List<Word>();


public Scripture(Reference reference,string words)
{
  _reference=reference;

  // string[] wordsSplit = words.Split("");

   foreach(string word in words.Split(" ")){

    _words.Add(new Word(word));


        
   }

   
 
}

public void HideRandomWords(int numberTohide)

{
    Random random = new Random();

    for (int i = 0; i < numberTohide; i++)
    {
      int replaceIndex = random.Next(0,_words.Count);

      if(!_words[replaceIndex].IsHidden())   
      {
         _words[replaceIndex].Hide();
      }
      else
      {
        i--;
      }

      

     }


}

public void Displaytext()
{
 Console.WriteLine(_reference.GetDisplayText());
  List<string> checkWords = new List<string>();
  

  foreach (Word word in _words)
  {
    // Console.WriteLine(word.GetDisplayText());
    // string joinedWords = string.Join(" ", word);

    string wordss =word.GetDisplayText().ToString();

    checkWords.Add(wordss);

    
  }
   string joinedWords = string.Join(" ", checkWords);
    Console.WriteLine(joinedWords);
    
}

public bool IsCompletelyHidden()
{
  foreach(Word word in _words)
  {
    if(!word.IsHidden())
    {
      return false;
    }
  }

  return true;
}

  

}