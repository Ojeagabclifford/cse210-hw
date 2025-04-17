

public class CyclingActivity : Activity
{

   private double _speed;

   public CyclingActivity(double speed, int time, DateTime date) : base(time,date)
   {
     _speed = speed;
   }





    public override float GetDistance()
    {
        
        return  GetSpeed() * GetTime();
    }
     public override float GetSpeed()
    {
        return (float) _speed;


    }    public override float GetPace()
    {

        return GetTime() / GetDistance();

    }


    public override string GetSummary()
{
   return $"{GetDate().ToString("yyyy/MM/dd")} Cycling ({GetTime()} min) Distance {GetDistance().ToString("F2")} Miles, Speed {GetSpeed().ToString("F2")} Kph, pace: {GetPace().ToString("F2")} min per km";
}





}