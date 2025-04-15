using System.Drawing;

public class ChechListGoal : Goal{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChechListGoal(string name, string description,string points, int target, int bonus):base(name,description,points)
        {

            _target = target;
            _bonus = bonus;

        }

        public void SetAmountCompleted(string amount)
        {
            _amountCompleted = int.Parse(amount);
        }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if(_amountCompleted == _target)
        {
            IsComplete();
            int totalPoints = int.Parse(GetPoints())  + _bonus;
            
            SetPoints(totalPoints.ToString());
            Console.WriteLine($"Congratulations! you have earned {totalPoints} points");
            
        }
      
        else
            {
                Console.WriteLine("wrong typo");
            }
              Console.WriteLine($"Congratulations! you have earned {GetPoints()} points");
    }


public override string GetDetailsString()
    {
        
       string status = IsComplete() ? "[X]" : "[]";

        return $"{status} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override bool IsComplete()
    {
       return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        //  string status = IsComplete() ? "[X]" : "[]";

       // return $"{status},{GetName()}({GetDescription()})";
        return $"ChechListGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
        
    }
}