namespace MindBoxMath;

/// <summary>
/// Provides math methods available to Triangle shape
/// </summary>
public class Triangle : Shape
{
    private double a,b,c;
    /// <summary>
    /// Creates instance of Triangle type
    /// </summary>
    /// <param name="a">length of 1st side[greater than 0]</param>
    /// <param name="b">length of 2nd side[greater than 0]</param>
    /// <param name="c">length of 3rd side[greater than 0]</param>
    public Triangle(double a, double b, double c) 
    { 
        if(a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("All sides must be greater than 0.");
        if(a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("Provided sides do not form triangle");
        this.a = a;
        this.b = b; 
        this.c = c; 
    }

    /// <summary>
    /// Calculates the square of triangle using three sides (<see href="https://en.wikipedia.org/wiki/Heron%27s_formula">Heron's formula</see>)
    /// </summary>
    /// <returns>sqaure of triangle</returns>
    public override double Sqaure()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}