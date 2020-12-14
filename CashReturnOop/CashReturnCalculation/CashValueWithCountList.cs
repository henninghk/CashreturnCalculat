using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CashReturnCalculation
{
    class CashValueWithCountList
    {
        List<CashValueWithCount> List;
        public CashValueWithCountList()
        {
            List = new List<CashValueWithCount>();
        }
        public void Add(CashValueWithCount MoneyValueWithCount)
        {
            List.Add(MoneyValueWithCount);
        }
        public void Reverse()
        {
            List.Reverse();
        }
        public int GetTotalValue()
        {
            var sum = 0;
            foreach(var x in List)
            {
                sum += x.Sum();
            }
            return sum;
        }
    }
}
