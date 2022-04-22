namespace MindBoxMath;

public class Circle : Shape
{
    private double radius;
    public Circle(double r) { radius=r; }
    public override double Sqaure()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}