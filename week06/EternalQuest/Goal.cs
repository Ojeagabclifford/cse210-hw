

public abstract class Goal
{
    private string  _shortName;
    private string _description;
    private string _points;

    
      public Goal()
      {
        
      }
    public Goal(string name,string decription,string points)
    {
        _shortName = name;
        _description = decription;
        _points = points;
    }

    public string GetName(){
        return _shortName;
    }

    public bool GetIsComplete(){
        return IsComplete();
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints(){
        return _points;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }
    public void SetShortDescription(string descritption)
    {
        _description = descritption;
    }

    public void SetPoints(string point)
    {
        _points = point;
    }


    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return _description;
    }

    public abstract string GetStringRepresentation();
}