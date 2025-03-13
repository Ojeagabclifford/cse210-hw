// This class will store the journal entry information e.g: date, prompt,
//  and entery text and then display it

using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entryText;

    public void DisplayEntryInformation()
    {
        Console.WriteLine($"Date: {_date} {_prompt} {_entryText}");
    }
}