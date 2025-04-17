
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description,string points):base(name,description,points)
        {

        }

      public EternalGoal(): base()
    {

    }
  

    public override void RecordEvent()
    {
                

                
                // SetName(name);
                // SetShortDescription(description);
                // SetPoints(point);
                
                  

               
               //IsComplete();
               Console.WriteLine($"Congratulations! you have earned {GetPoints()} points");


    
        
     
    }

    public override bool IsComplete()
    {
        return false;
    }


    //  public string GetDetailsString()
    // {
        
    //     string status =  "[]";
    //     return $"{status} {GetName()} ({GetDescription()})";
    // }

    public override string GetStringRepresentation()
    {

        // string status = "[]";

       // return $"{status},{GetName()}({GetDescription()})";
        return $"EnternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
       
        
    }

    }