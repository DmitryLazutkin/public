namespace MindBoxMath;

/// <summary>
/// Provides math methods available to Triangle shape
/// </summary>
public class Triangle : Shape
{
    private double a,b,c;

    /// <summary>
    /// Shows whether triangle is right or not
    /// </summary>
    /// <value>true if triangle is right</value>
    public bool IsRight { get; }
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
        IsRight = CheckIsRight();
    }

    /// <summary>
    /// Calculates the square of triangle using three sides (<see href="https://en.wikipedia.org/wiki/Heron%27s_formula">Heron's formula</see>)
    /// </summary>
    /// <returns>sqaure of triangle</returns>
    public override double CalcSqaure()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    private bool CheckIsRight()
    {
        if(a > b && a > c)
        {
            return Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }
        else if(b > a && b > c)
        {
            return Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2);
        }
        else
        {
            return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
        }
    }
}