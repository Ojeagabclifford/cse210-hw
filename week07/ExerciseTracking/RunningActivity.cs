
 public class  RunningActivity : Activity
 {

    private double _distance;

    public RunningActivity(double distance,int time, DateTime date ) : base( time, date)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        
        return (float)_distance;
    }
     public override float GetSpeed()
    {
        return GetDistance()/ GetTime() * 60f;


    }    public override float GetPace()
    {

        return GetTime() / GetDistance();

    }


    

public override string GetSummary()
{
   return $"{GetDate().ToString("yyyy/MM/dd")} Runing ({GetTime()} min) Distance {GetDistance().ToString("F2")} Miles, Speed {GetSpeed().ToString("F2")} Kph, pace: {GetPace().ToString("F2")} min per km";
}

 }