public class Activity
{
    private string _date;
    protected int _length;
    protected string _activityType;

    public Activity(int length)
    {
        _length = length;

        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();
    }

    public virtual decimal GetDistance()
    {
        return 0;
    }

    public virtual decimal GetSpeed()
    {
        return 0;
    }

    public virtual decimal GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_length} min) - Distance: {GetDistance().ToString("0.##")} km, Speed: {GetSpeed().ToString("0.##")} kph, Pace: {GetPace().ToString("0.##")} min per km";
    }
    
}