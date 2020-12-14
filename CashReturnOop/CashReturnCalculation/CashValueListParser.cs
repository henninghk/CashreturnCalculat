using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CashReturnCalculation
{
   static class CashValueListParser
    {
       
        public static CashValueWithCount ParseCashString(string paymentString, CashValueList CVL)
        {

            if (!paymentString.Contains("x") || !paymentString.EndsWith("kr")) return null;
            var xIndex = paymentString.IndexOf("x");
            var countString = paymentString.Substring(0, xIndex);
            var isSuccessCount = int.TryParse(countString, out int count);
            if (!isSuccessCount) return null;
            var cashItemString = paymentString.Substring(xIndex + 1).TrimEnd('k', 'r');
            var isSuccessCashItem = int.TryParse(cashItemString, out int cashItem);
            if (!isSuccessCashItem) return null;
            var cashValue = CVL.FirstOrDefault(cashItem);
            if (cashValue == null) return null;
            return new CashValueWithCount(cashValue, count);
        }
    }
}
