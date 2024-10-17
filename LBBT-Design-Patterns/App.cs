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
        private int _price;
        private ITaxCalculator _taxCalculator;

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
            Console.WriteLine(_taxCalculator.calculateTax(_price));
        }
    }
}
