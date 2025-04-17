using System.Reflection.Metadata.Ecma335;

public abstract class Activity

{
    // private  float  distance;
    // private float speed;
    // private float _pace;
     private DateTime _date;
    private int _time;


    public Activity( int time, DateTime date){
    // {
    //     _distance = distance;
    //     _speed = speed;
    //     _pace = pace;
         _date = date;
       _time = time;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual int GetTime()
    {
        return _time;
    }
    public virtual DateTime GetDate()
    {

        return _date;

    }

    

public virtual string GetSummary()
{
    return $"";
}

}