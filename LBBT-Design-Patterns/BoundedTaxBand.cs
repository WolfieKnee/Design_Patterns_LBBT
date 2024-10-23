using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal class BoundedTaxBand(double TaxRate, int LowerThreshold, int UpperThreshold) : ITaxStrategy
    {
        private double Tax;
        private double TaxRate { get; set; } = TaxRate;
        private int LowerThreshold { get; set; } = LowerThreshold;
        private int UpperThreshold { get; set; } = UpperThreshold;

        public void ApplyTax(int Price, ConcurrentBag<int> taxCalculationResults)
        {
            if (Price < LowerThreshold)
            {
                taxCalculationResults.Add(0);
            } else if (Price > UpperThreshold)
            {
                Tax = (UpperThreshold - LowerThreshold) * TaxRate;
                int TaxInt = (int)Math.Ceiling(Tax);
                taxCalculationResults.Add(TaxInt);
            }
            else { 
                Tax = (Price - LowerThreshold) * TaxRate;
                int TaxInt = (int)Math.Ceiling(Tax);
                taxCalculationResults.Add(TaxInt);
            }
        }

    }
}
