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
    public void Test_tax0(int price, int tax)
    {
        // Arrange
        ITaxCalculator _aTaxCalculator = new LBBTCalculator();

        // Act
        double _actual = _aTaxCalculator.calculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }


    [Test]
    [TestCase(235000, 1800)]
    public void TestTax2Pc(int price, double tax)
    {
        // Arrange
        ITaxCalculator _aTaxCalculator = new LBBTCalculator();

        // Act
        double _actual = _aTaxCalculator.calculateTotalTax(price);

        // Assert
        Assert.That(_actual, Is.EqualTo(tax));
    }
}