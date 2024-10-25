public class Rectangle : Shape
{
    private double _lengh;
    private double _width;

    public Rectangle(string color, double lengh, double width) : base(color)
    {
        _lengh = lengh;
        _width = width;
    }

    public override double GetArea()
    {
        return _lengh * _width;
    }
}