using NUnit.Framework;
using MindBoxMath;
using System;

namespace MindBoxMathTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CircleSqaure()
    {
        double radius = 5;
        Shape circle = new Circle(radius);
        double res = Calculator.Sqaure(circle);
        Assert.AreEqual(res, Math.PI * Math.Pow(radius, 2));
    }
}