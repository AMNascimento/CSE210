public class Running : Activity
{
    private decimal _distance;

    public Running(int length, decimal distance) : base(length)
    {
        _activityType = "Running";
        _distance = distance;
    }

    public override decimal GetDistance()
    {
        return _distance;
    }

    public override decimal GetSpeed()
    {
        return _distance / _length * 60;
    }

    public override decimal GetPace()
    {
        return _length / _distance;
    }
}