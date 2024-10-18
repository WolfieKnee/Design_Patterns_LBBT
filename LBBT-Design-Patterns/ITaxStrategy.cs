using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal interface ITaxStrategy
    {
        double TaxRate { get; set; }
        // this is the threshold at which the rate applies
        int TaxThreshold { get; set; }
    }
}
