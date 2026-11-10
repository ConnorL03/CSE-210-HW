using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red" , 5);
        // Console.WriteLine(square.GetColor()); 
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(4, 6, "green");
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(3, "blue");
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}