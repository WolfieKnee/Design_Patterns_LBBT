using LBBT_Design_Patterns;

namespace LBBT_Tests;

public class Tests
{
    [Test]
    [TestCase(0, 0)]
    [TestCase(145000, 0)]
    [TestCase(145050, 1)]
    public void Test_0pcRate(int price, int tax)
    {
        DoTest(price, tax, nameof(Test_0pcRate));
    }


    [Test]
    [TestCase(235000, 1800)]
    [TestCase(250000, 2100)]
    public void TestTax2Pc(int price, double tax)
    {
        DoTest(price, tax, nameof(TestTax2Pc));
    }

    [Test]
    [TestCase(250500, 2125)]
    [TestCase(325000, 5850)]
    public void TestTax5Pc(int price, double tax)
    {
        DoTest(price, tax, nameof(TestTax5Pc));
    }

    [Test]
    [TestCase(325500, 5900)]
    [TestCase(750000, 48350)]
    public void TestTax10Pc(int price, double tax)
    {
        DoTest(price, tax, nameof(TestTax10Pc));
    }

    [Test]
    [TestCase(750500, 48410)]
    [TestCase(1000000, 78350)]
    public void TestTax12Pc(int price, double tax)
    {
        DoTest(price, tax, nameof(TestTax12Pc));
    }

    private void DoTest(int price, double expected, string testName)
    {
        var actual = _lbbtCalculator.CalculateTotalTax(price);
        Assert.That(actual, Is.EqualTo(expected), testName);
    }

    private ITaxCalculator _lbbtCalculator;

    [SetUp]
    public void Setup()
    {
        _lbbtCalculator = new LBBTCalculator();
    }
}