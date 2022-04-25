namespace MindBoxMath;

/// <summary>
/// Provides math methods available to Circle shape
/// </summary>
public class Circle : Shape
{
    private double radius;
    /// <summary>
    /// Creates instance of Circle type 
    /// </summary>
    /// <param name="r">radius of the circle[positive]</param>
    /// <exception>ArgumentException</exception>
    public Circle(double r) 
    { 
        if(r < 0) throw new ArgumentException("Radius should be positive.");
        radius = r; 
    }

    /// <summary>
    /// Calculates the square of circle using pi * R^2 formula
    /// </summary>
    /// <returns>square of circle</returns>
    public override double CalcSqaure()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}