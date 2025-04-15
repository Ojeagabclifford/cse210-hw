using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

//  Console.Write("What is the name your goal? ");
//                 string name = Console.ReadLine();
//                 Console.WriteLine("What is a short description of it? ");
//                 string description = Console.ReadLine();
//                 Console.WriteLine("What is the amount of points associated with this goal?");
//                 string point = Console.ReadLine();
//                 SimpleGoal simpleGoal = new SimpleGoal(name,description,point);

//                 simpleGoal.RecordEvent();

//                 Console.WriteLine(simpleGoal.GetStringRepresentation());
//                 simpleGoal.RecordEvent();
                
//                 Console.WriteLine(simpleGoal.GetStringRepresentation());

GoalManager goalManager = new GoalManager();

goalManager.Start();

// NegativeGoals  negativeGoals = new NegativeGoals("s","e","5");

// negativeGoals.RecordEvent();
// negativeGoals.GetDetailsString();


// negativeGoals.GetDetailsString();

       

        
    }
}