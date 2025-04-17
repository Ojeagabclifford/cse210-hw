
public class NegativeGoals: Goal
{
   

    public NegativeGoals(string name,string decription,string points) : base(name,decription,points)
    {
        

    }

   


    

     public override void RecordEvent()
    {
        
             
            
        
            // _pointRemove = int.Parse(GetPoints());
            // int currentpoint = int.Parse(GetPoints());
            //int totalPoints = - int.Parse(GetPoints());
           
            // totalPoints--;
           //  Console.WriteLine($"-{totalPoints}");
            
            
           
            SetPoints($"{int.Parse(GetPoints())}");
            Console.WriteLine($"Sorry! you have Lost {GetPoints()} points");

            // IsComplete();
            
            
        
    }

    // public int GetPointsRemove()
    // {
    //     return _pointRemove;
    // }

    

    public override bool IsComplete()
    {
        return true;
    }


   

    public override string GetStringRepresentation()
    {

       // string status = _isComplete ? "[X]" : "[]";

       // return $"{status},{GetName()}({GetDescription()})";
        return $"NegativeGoals:{GetName()},{GetDescription()},{GetPoints()}";
       
        
    }



}