
// this journal class is used to store the journal enteries in a list and then 
// display them save it to a file and from a file

using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    // create a list of entries
    public List <Entry> _enteries = new List<Entry>();

// create a function to add entry to the journal
    public void addEntry(Entry entry)
    {
        
        _enteries.Add(entry);
    }

// create a function to display the entrys in the journal
    public void DisplayEntry()
    {
        Console.WriteLine("Journal Entries");
         foreach(Entry entry in _enteries){
                entry.DisplayEntryInformation();
         }
    }

    public void SaveToFile(string filename){
    //   create a function to save the entrys to a file
    // create a if statement to check if the file is a csv file
       if(filename == $"{filename}.csv"){
        using  StreamWriter writer = new StreamWriter(filename);
        {foreach(Entry entry in _enteries){
            
            writer.WriteLine($"{entry._date},{entry._prompt},{entry._entryText}");
        }}}
        // create a if statement to check if the file is a txt file
        else if (filename == $"{filename}.txt")
        { 
            using  StreamWriter writer = new StreamWriter(filename);
            foreach(Entry entry in _enteries){
            
            writer.WriteLine($"{entry._date}-{entry._prompt}-{entry._entryText}");
            }
        }
        else
        {
            Console.WriteLine("file does not exist");
        }
    }

    public void Loadfromfile(string filename){
      
       
      
// create a function to load the entrys from a file
// create a if statement to check if the file is a csv file
          if(File.Exists($"{filename}.csv")){
            using StreamReader reader = new StreamReader($"{filename}.csv");

            Console.WriteLine("file is loading");
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    _enteries.Clear();
                    string[] parts = line.Split(',');
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._entryText = parts[2];
                    _enteries.Add(entry);

                }
            }
        
        }
        // create a if statement to check if the file is a txt file
        if(File.Exists($"{filename}.txt")){
            using StreamReader reader = new StreamReader($"{filename}.txt");

            Console.WriteLine("file is loading");
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    _enteries.Clear();
                    string[] parts = line.Split('-');
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._entryText = parts[2];
                    _enteries.Add(entry);

                }
            }
        
        }

        else
        {
            Console.WriteLine("file does not exist");
        }

    }
}