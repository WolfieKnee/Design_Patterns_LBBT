using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal class LBBTCalculator : ITaxCalculator
    {
        private int _housePrice;
        private List<ITaxStrategy> _TaxBands { get; }
        public double _TotalTax { get; private set; } = 0;

        public LBBTCalculator()
        {
            TaxBand _2PcTaxBand = new(0.02, 145000);
            TaxBand _0PcTaxBand = new(0, 0);
            // this needs to be ordered greatest to least to work with iteration
            _TaxBands = new() { 
                _2PcTaxBand,
                _0PcTaxBand
            };
        }

        public void applyTaxBands(int TaxableAmount)
        {
            
            foreach (ITaxStrategy taxStrategy in _TaxBands)
                {
                    Console.WriteLine($"{taxStrategy.TaxRate}%");
                if (TaxableAmount > taxStrategy.TaxThreshold) {
                    _TotalTax += (TaxableAmount - taxStrategy.TaxThreshold) * taxStrategy.TaxRate;
                    TaxableAmount -= taxStrategy.TaxThreshold;
                }
                    
                }
        }

        public int calculateTotalTax(int price)
        {
            applyTaxBands(price);
            return (int)_TotalTax;
        }
    }
}
