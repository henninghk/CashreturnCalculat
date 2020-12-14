using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CashReturnCalculation
{
    class CashValueList
    {
        List<cash> Liste { get; }
        public CashValueList()
        {
            Liste = new List<cash>();
        }
    
        public void Add(cash cashesValues)
        {
            Liste.Add(cashesValues);
        }
        public int Length()
        {
            return Liste.Count;
        }
        public cash FirstOrDefault(int cashItem)
        {
                return Liste.FirstOrDefault(c => c.GetValue() == cashItem);
        }
        public void Sort(int amount)
        {
            Liste.Reverse();
            var remaining = amount;
            int count = 0;
            foreach(var x in Liste)
            {
                count = remaining / x.GetValue();
                if(count > 0) {
                    remaining -= count * x.GetValue();
                    Console.WriteLine($"- {count}x{x.GetValue()}kr");
                }
            }
        }
        public CashValueList GetSetCashValueList()
        {
            CashValueList cashItemValues = new CashValueList();


            cashItemValues.Add(new cash(1, true));
            cashItemValues.Add(new cash(5, true));
            cashItemValues.Add(new cash(10, true));
            cashItemValues.Add(new cash(20, true));
            cashItemValues.Add(new cash(50, false));
            cashItemValues.Add(new cash(100, false));
            cashItemValues.Add(new cash(200, false));
            cashItemValues.Add(new cash(500, false));
            cashItemValues.Add(new cash(1000, false));
            return cashItemValues;
        }
    }
}
