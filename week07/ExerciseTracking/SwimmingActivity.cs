using System.Security.Cryptography.X509Certificates;

public class SwimmingActivity : Activity
{
    private int _laps;
    

    public SwimmingActivity(int lap, int time, DateTime date): base(time, date)
    {
        _laps = lap;

    }

    
    
    public override float GetPace()
    {

        return GetTime() / GetDistance();

    }


    public override float GetDistance()
    {
      float distance =   _laps * 50f/1000f;
      return distance;
    }

    

    public override float GetSpeed()
    {
        return GetDistance()/ GetTime() * 60f;


    }

    public override string GetSummary()
{
    return $"{GetDate().ToString("yyyy/MM/dd")} {_laps} lap Swimming ({GetTime()} min) Distance {GetDistance().ToString("F2")} km, Speed {GetSpeed().ToString("F2")} Kph, pace: {GetPace().ToString("F2")} min per km";
}


}