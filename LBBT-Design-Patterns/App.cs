using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("LBBT_Tests")]

namespace LBBT_Design_Patterns
{
    
    internal class App
    {
        static void Main()
        {
            ITaxCalculator anLBBTCalculator =  new LBBTCalculator(235000);
            Console.WriteLine(anLBBTCalculator.calculateTax());
        }
    }
}
