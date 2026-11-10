public class Circle : Shape
{
	public double Radius;

    public Circle(double radius, string color) : base(color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
