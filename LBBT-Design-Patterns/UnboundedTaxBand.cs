using System.Collections.Concurrent;

namespace LBBT_Design_Patterns
{
    public class UnboundedTaxBand(double TaxRate, int LowerThreshold) : ITaxStrategy
    {
        private double Tax;

        private double TaxRate { get; set; } = TaxRate;
        private int LowerThreshold { get; set; } = LowerThreshold;

        public void ApplyTax(int Price, ConcurrentBag<int> taxCalculationResults)
        {
            if (Price < LowerThreshold)
            {
                taxCalculationResults.Add(0);
            }
            else
            {
                Tax = (Price - LowerThreshold) * TaxRate;
                int TaxInt = (int)Math.Ceiling(Tax);
                taxCalculationResults.Add(TaxInt);
            }
        }
    }
}