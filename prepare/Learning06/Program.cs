using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("blue", 3.4);
        Rectangle rectangle = new Rectangle("red", 2, 2.5);
        Circle circle = new Circle("Black", 7);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
        
        // Console.WriteLine($"Square: {square.GetColor()} - {square.GetArea()}");
        // Console.WriteLine($"Rectangle: {rectangle.GetColor()} - {rectangle.GetArea()}");
        // Console.WriteLine($"Circle: {circle.GetColor()} - {circle.GetArea()}");
    }
}