using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CashReturnCalculation
{
    class CashValueWithCount
    {
        cash CashValue;
        public int Value;
        public int Count;
        public CashValueWithCount(cash cashValue, int count)
        {
            CashValue = cashValue;
            Value = CashValue.GetValue();
            Count = count;
        }
        public int Sum()
        {
            return Value * Count;
        }
    }
}