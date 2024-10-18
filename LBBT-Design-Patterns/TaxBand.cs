using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal class TaxBand(double TaxRate, int TaxThreshold) : ITaxStrategy
    {
        public double TaxRate { get; set; } = TaxRate;
        public int TaxThreshold { get; set; } = TaxThreshold;
    }
}
