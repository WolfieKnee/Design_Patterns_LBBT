using System.ComponentModel;
using System.Diagnostics;
using LBBT_Design_Patterns;
using NUnit.Framework;

namespace LBBT_Tests;

public class Tests
{
    [Test]
    [TestCase(0, 0)]
    [TestCase(145000, 0)]
    [TestCase(145050, 1)]
    public void Test_0pcRate(int price, int tax)
    {
        // Arrange
        LBBTCalculator _aTaxCalculator = new();

        // Act
        double _actual = _aTaxCalculator.CalculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }


    [Test]
    [TestCase(235000, 1800)]
    [TestCase(250000, 2100)]
    public void TestTax2Pc(int price, double tax)
    {
        // Arrange
        LBBTCalculator _aTaxCalculator = new();

        // Act
        double _actual = _aTaxCalculator.CalculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }

    [Test]
    [TestCase(250500, 2125)]
    [TestCase(325000, 5850)]
    public void TestTax5Pc(int price, double tax)
    {
        // Arrange
        LBBTCalculator _aTaxCalculator = new();

        // Act
        double _actual = _aTaxCalculator.CalculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }

    [Test]
    [TestCase(325500, 5900)]
    [TestCase(750000, 48350)]
    public void TestTax10Pc(int price, double tax)
    {
        // Arrange
        LBBTCalculator _aTaxCalculator = new();

        // Act
        double _actual = _aTaxCalculator.CalculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }

    [Test]
    [TestCase(750500, 48410)]
    [TestCase(1000000, 78350)]
    public void TestTax12Pc(int price, double tax)
    {
        // Arrange
        LBBTCalculator _aTaxCalculator = new();

        // Act
        double _actual = _aTaxCalculator.CalculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }
}