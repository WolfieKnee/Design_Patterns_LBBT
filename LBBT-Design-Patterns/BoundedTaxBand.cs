using System;
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

        public int ApplyTax(int Price)
        {
            if (Price < LowerThreshold) {
                return 0;
            }
            if (Price > UpperThreshold)
            {
                Tax = (UpperThreshold - LowerThreshold) * TaxRate;
                return (int)Math.Ceiling(Tax);
            }
            else { 
                Tax = (Price - LowerThreshold) * TaxRate;
                return (int)Math.Ceiling(Tax);
            }
        }
    }
}
