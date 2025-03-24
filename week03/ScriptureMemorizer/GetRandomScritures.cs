
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class GetRandomScritures
{
     private List<string> _bookList = new  List<string>();
    //  Reference _reference;
     
    

    
public void GetreferenNmae()
{
    using StreamReader reader = new StreamReader($"Scriptures.txt");
                {
                    
                string line;
                while((line = reader.ReadLine()) != null)
                {

                    
                    
                    string[] parts = line.Split("~");
                    

                    _bookList.Add($"{parts[0]},{parts[1]},{parts[2]},{parts[3]},{parts[4]}");

                   
                    
                    

                }
            }

    
}


public (Reference,string) Display()
{
    
          Random random = new Random();
        // create a random index to select a random prompt
        int index = random.Next(_bookList.Count);
        // create a return statement to return the random prompt
         string part = _bookList[index];

         string[] scriptureparts = part.Split(",");
         
      Reference reference = new Reference();

         
      reference.SetReffernce(scriptureparts[0],int.Parse(scriptureparts[1]),int.Parse(scriptureparts[2]),int.Parse(scriptureparts[3]));

      
    string text = scriptureparts[4];
    return (reference, text);

    
}






   

 
}