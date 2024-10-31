public class Cycling : Activity
{
    private decimal _speed;

    public Cycling(int length, decimal speed) : base(length)
    {
        _activityType = "Cycling";
        _speed = speed;
    }

    public override decimal GetDistance()
    {
        return _speed * _length / 60;
    }

    public override decimal GetSpeed()
    {
        return _speed;
    }

    public override decimal GetPace()
    {
        return 60 / _speed;
    }
}