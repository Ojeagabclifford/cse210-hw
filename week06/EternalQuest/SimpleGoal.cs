
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name,string decription,string points) : base(name,decription,points)
    {

    }
   

    public void SetComplete(string complete)
    {
        _isComplete = bool.Parse(complete);
    }


    public  SimpleGoal(): base()
    {

    }
  

    public override void RecordEvent()
    {
                

                
                // SetName(name);
                // SetShortDescription(description);
                // SetPoints(point);
                
                    _isComplete = true;
                     Console.WriteLine($"Congratulations! you have earned {GetPoints()} points");

               
               


    
        
     
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    //  public override string GetDetailsString()
    // {
        
    //     string status = IsComplete() ? "[X]" : "[]";
    //     return $"{status} {GetName()} ({GetDescription()})";
    // }

    public override string GetStringRepresentation()
    {

       // string status = _isComplete ? "[X]" : "[]";

       // return $"{status},{GetName()}({GetDescription()})";
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
       
        
    }
}