

public class ActivityList
{
    private List<Activity> _activities = new List<Activity>();

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }



    public void DisplayDetials()
    {
        foreach(Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
    }
    }


}