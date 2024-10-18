using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal interface ITaxStrategy
    {
        public double TaxRate { get; set; }
        public int LowerThreshold { get; set; }
        public int UpperThreshold { get; set; }
        public int ApplyTax(int Price);
        
    }
}
