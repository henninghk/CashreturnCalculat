using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CashReturnCalculation
{
    class CashReturnCalculationWithoutOO
    {
      
        public static void Run()
        {
            CashValueList premadeCashValueList = new CashValueList();
            PaymentHandler paymentHandler = new PaymentHandler(premadeCashValueList.GetSetCashValueList());
            Console.WriteLine("Hvor mye skal det betales? ");
            var paymentAmountString = Console.ReadLine();
            var paymentAmount = Convert.ToInt32(paymentAmountString);
            paymentHandler.AcceptPayment(paymentAmount);
            paymentHandler.ShowReturnAmount();
        }
    }
}
