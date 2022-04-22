namespace MindBoxMath;

/// <summary>
/// Provides math functionality over shape objects 
/// </summary>
public class Calculator 
{
    /// <summary>
    /// Calculate sqaure of shape
    /// </summary>
    /// <param name="s">instance of shape to calculate sqaure</param>
    /// <returns>square of shape</returns>
    public static double Sqaure(Shape s)
    {
        return s.Sqaure();
    }
}