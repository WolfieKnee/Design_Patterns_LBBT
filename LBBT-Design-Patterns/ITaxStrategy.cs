using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal interface ITaxStrategy
    {
        public Double TaxRate { get; }
        // this is the threshold at which the rate applies
        public int taxThreshold { get; }
    }
}
