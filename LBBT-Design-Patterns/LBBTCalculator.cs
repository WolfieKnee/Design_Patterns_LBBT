using System;
using System.Collections.Concurrent;
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
        private List<Thread> threadStore = [];
        private ConcurrentBag<int> taxCalculationResults = new ConcurrentBag<int>();
        public LBBTCalculator()
        {
            BoundedTaxBand _2PcTaxBand = new (0.02, 145001, 250000);
            BoundedTaxBand _5PcTaxBand = new (0.05, 250001, 325000);
            BoundedTaxBand _10PcTaxBand = new (0.10, 325001, 750000);
            UnboundedTaxBand _12PcTaxBand = new (0.12, 750001);
            TaxBands = [
                _2PcTaxBand,
                _5PcTaxBand,
                _10PcTaxBand,
                _12PcTaxBand,
            ];
        }

        private void ApplyTaxBands(int price)
        {
            // Create a new thread for each taxStrategy
            foreach (ITaxStrategy TaxBand in TaxBands)
                {
                threadStore.Add(new Thread(() => TaxBand.ApplyTax(price, taxCalculationResults)));
                }

            // Start all the threads
            foreach (Thread thread in threadStore)
            {
                thread.Start();
            }

            // bring the threads back here after 1s - this is blocking
            foreach (var thread in threadStore)
            {
                thread.Join(1000);
            }

            TotalTax = taxCalculationResults.Sum();

        }

        public int CalculateTotalTax(int price)
        {
            ApplyTaxBands(price);
            return TotalTax;
        }
    }
}
