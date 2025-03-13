//  this program will generate a random prompt for the user to write about
//  in their journal entry

using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // create a list of prompts
    public List<string> _prompts = new List<string>()
    {
        "What is your favorite color?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
 
//  create a function to generate a random prompt
    public string GeneratePrompt()
    {
        Random random = new Random();
        // create a random index to select a random prompt
        int index = random.Next(_prompts.Count);
        // create a return statement to return the random prompt
        return _prompts[index];


    }

}