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
        private readonly int _price;
        private readonly LBBTCalculator _taxCalculator;

        public App()
        {
            _price = 235000;
            _taxCalculator = new LBBTCalculator();
        }


        static void Main()
        {
            new App().Run();
            
        }

        private void Run() { 
            Console.WriteLine("Tax on £"+ _price +" is "+_taxCalculator.CalculateTotalTax(_price));
        }
    }
}
