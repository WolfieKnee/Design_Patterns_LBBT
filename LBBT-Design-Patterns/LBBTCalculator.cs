using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal class LBBTCalculator
    {
        private List<ITaxStrategy> TaxBands { get; }
        public int TotalTax { get; private set; } = 0;

        public LBBTCalculator()
        {
            TaxBand _2PcTaxBand = new(0.02, 145001, 250000);
            TaxBand _5PcTaxBand = new(0.05, 250001, 325000);

            TaxBands = [ 
                _2PcTaxBand,
                _5PcTaxBand,
            ];
        }

        public void ApplyTaxBands(int price)
        {
            foreach (ITaxStrategy taxStrategy in TaxBands)
                {
                TotalTax += taxStrategy.ApplyTax(price);
                }
        }

        public int CalculateTotalTax(int price)
        {
            ApplyTaxBands(price);
            return (int)TotalTax;
        }
    }
}
