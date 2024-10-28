using System.Collections.Concurrent;

namespace LBBT_Design_Patterns;

public interface ITaxStrategy
{
    /// <summary>
    ///     Calculates tax on <paramref name="price" /> using the rules for this instance and
    ///     stores results in <paramref name="taxCalculationResults" />
    /// </summary>
    public void ApplyTax(int price, ConcurrentBag<int> taxCalculationResults);
}