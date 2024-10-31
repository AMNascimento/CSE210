public class Swimming : Activity
{
    private int _laps;

    public Swimming(int length, int laps) : base(length)
    {
        _activityType = "Swimming";
        _laps = laps;
    }

    public override decimal GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override decimal GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override decimal GetPace()
    {
        return 60 / GetSpeed();
    }
}