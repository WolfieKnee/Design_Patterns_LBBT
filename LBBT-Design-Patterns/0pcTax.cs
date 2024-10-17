using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal class _0pcTax : ITaxStrategy
    {
        public double TaxRate => 0;
        public int taxThreshold => 0;
    }
}
