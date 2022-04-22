namespace MindBoxMath;

public class Triangle : Shape
{
    private double a,b,c;
    public Triangle(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
    public override double Sqaure()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}