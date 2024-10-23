using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal interface ITaxStrategy
    {
        public void ApplyTax(int Price, ConcurrentBag<int> taxCalculationResults);
    }
}
