using NUnit.Framework;
using MindBoxMath;
using System;
using System.Collections.Generic;

namespace MindBoxMathTests;

public class HappyPathTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CircleSqaure()
    {
        double radius = 5.5;
        var square = new Circle(radius).CalcSqaure();
        Assert.AreEqual(square, Math.PI * Math.Pow(radius, 2));
    }

    [Test]
    public void ZeroRadius()
    {
        try
        {
            var sqaure = new Circle(0).CalcSqaure();
            Assert.Zero(sqaure);
        }
        catch(ArgumentException)
        {
            Assert.Fail("Zero radius should be usable and result in zero square");
        }
    }

    [Test]
    public void TriangleSquare()
    {
        double a = 3.123456789;
        double b = 4.123456789;
        double c = 5.123456789;
        var square = new Triangle(a, b, c).CalcSqaure();
        Assert.AreEqual(square, 6.438461847202264);
    }

    [Test]
    public void SquaredTriangle()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        var isRight = new Triangle(a, b, c).IsRight;
        Assert.True(isRight);
    }

    [Test]
    public void CalculatorSqaure()
    {
        double radius = 3.8;
        double a = 3.5;
        double b = 4.2;
        double c = 5.5;
        var shapes = new List<Shape>();
        shapes.Add(new Triangle(a, b, c));
        shapes.Add(new Circle(radius));

        foreach(var s in shapes)
        {
            Assert.AreEqual(Calculator.CalcSqaure(s), s.CalcSqaure());
        }

    }
}