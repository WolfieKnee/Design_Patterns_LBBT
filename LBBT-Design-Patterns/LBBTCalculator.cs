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
            TaxBand _2PcTaxBand = new(0.02, 145001, 250000);
            _TaxBands = new() { 
                _2PcTaxBand,
            };
        }

        public void applyTaxBands(int price)
        {
            int TaxableAmount = price;


            foreach (ITaxStrategy taxStrategy in _TaxBands)
                {
                _TotalTax += taxStrategy.ApplyTax(price);
                //if (TaxableAmount > taxStrategy.LowerThreshold) {
                //    _TotalTax += (TaxableAmount - taxStrategy.LowerThreshold) * taxStrategy.TaxRate;
                //    TaxableAmount -= taxStrategy.LowerThreshold;
                //}

                }
        }

        public int calculateTotalTax(int price)
        {
            applyTaxBands(price);
            return (int)_TotalTax;
        }
    }
}
