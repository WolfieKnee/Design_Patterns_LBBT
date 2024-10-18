using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
    internal interface ITaxStrategy
    {
        public int ApplyTax(int Price);
    }
}
