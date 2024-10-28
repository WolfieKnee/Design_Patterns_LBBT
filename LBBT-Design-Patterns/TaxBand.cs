using System.Collections.Concurrent;

namespace LBBT_Design_Patterns;

/// <summary>
///   A banded tax strategy where a <paramref name="taxRate"/> will be applied to any amount
///   between a <paramref name="lowerThreshold"/> and <paramref name="upperThreshold"/> if specified,
///   otherwise limitless above <paramref name="lowerThreshold"/>
/// </summary>
public class TaxBand(double taxRate, int lowerThreshold, int? upperThreshold = null)
    : ITaxStrategy
{
    public void ApplyTax(int price, ConcurrentBag<int> taxCalculationResults)
    {
        double totalTax = 0;
        if (price > upperThreshold)
        {
            totalTax += (upperThreshold.Value - lowerThreshold) * taxRate;
        }
        else if (price > lowerThreshold)
        {
            totalTax += (price - lowerThreshold) * taxRate;
        }

        // TODO consider rounding behaviour
        var resultant = (int)Math.Ceiling(totalTax);
        if (resultant != 0) taxCalculationResults.Add(resultant);
    }
}