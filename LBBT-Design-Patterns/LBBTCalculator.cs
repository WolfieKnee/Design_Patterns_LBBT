﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBBT_Design_Patterns
{
        internal class LBBTCalculator
        {
            private int _housePrice;
            public LBBTCalculator(int price) { 
                _housePrice = price;
            }
            public double calculateTax() {
                if (_housePrice <= 145000)
                {
                    return 0;
                }
                else
                {
                    return 0.02 * (_housePrice-145000);
                }
            }
        }
}
