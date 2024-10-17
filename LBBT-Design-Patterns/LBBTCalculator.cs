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
        private List<ITaxStrategy> _TaxStratgies { get; }
        private _0pcTax _a0PcTax { get; }
        private _2pcTax _a2PcTax { get; }
        public double _TotalTax { get; private set; } = 0;

        public LBBTCalculator()
        {
            _a0PcTax = new _0pcTax();
            _a2PcTax = new _2pcTax();

            // this needs to be ordered greatest to least to work with iteration
            _TaxStratgies = new() { 
                _a2PcTax,
                _a0PcTax
            };
        }

        public void applyStrategies(int TaxableAmount)
        {
            
            foreach (ITaxStrategy taxStrategy in _TaxStratgies)
                {
                    Console.WriteLine($"{taxStrategy.TaxRate}%");
                if (TaxableAmount > taxStrategy.taxThreshold) {
                    _TotalTax += (TaxableAmount - taxStrategy.taxThreshold) * taxStrategy.TaxRate;
                    TaxableAmount -= taxStrategy.taxThreshold;
                }
                    
                }
        }

        public int calculateTotalTax(int price)
        {
            applyStrategies(price);
            return (int)_TotalTax;
        }
    }
}
