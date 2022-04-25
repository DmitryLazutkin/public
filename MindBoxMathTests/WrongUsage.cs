using NUnit.Framework;
using MindBoxMath;
using System;
using System.Collections.Generic;

namespace MindBoxMathTests;

public class WrongUsageTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NegativeRadius()
    {
        try
        {
            var circle = new Circle(-2);
            Assert.Fail("No check for negative radius");
        }
        catch(ArgumentException)
        {
            Assert.Pass();
        }
    }

    [Test]
    public void NegativeSides()
    {
        try
        {
            var circle = new Circle(-2);
            Assert.Fail("No check for negative radius");
        }
        catch(ArgumentException)
        {
            Assert.Pass();
        }
    }

    [Test]
    public void NotATriangle()
    {
        try
        {
            var not_a_triangle = new Triangle(2, 3, 6);
            Assert.Fail("No check for the situation where provided sides can not form triangle");
        }
        catch(ArgumentException)
        {
            Assert.Pass();
        }
    }
}