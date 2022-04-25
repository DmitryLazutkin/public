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
    /// <returns>square of shape or <exception>NullReferenceException</exception></returns>
    public static double CalcSqaure(Shape s)
    {
        return s.CalcSqaure();
    }
}