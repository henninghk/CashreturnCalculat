using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CashReturnCalculation
{
    class cash
    {
        public int Value;
        public bool IsCoin;

        public cash(int value, bool isCoin)
        {
            Value = value;
            IsCoin = isCoin;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
