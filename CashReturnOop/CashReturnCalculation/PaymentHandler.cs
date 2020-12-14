using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CashReturnCalculation
{
    class PaymentHandler
    {
        CashValueWithCountList List;
        CashValueList CashItemValuesList;
        int paymentAmount;
        public PaymentHandler(CashValueList MoneyValueList)
        {
            List = new CashValueWithCountList();
            CashItemValuesList = MoneyValueList;
            paymentAmount = 0;
            
        }
        public void Add(CashValueWithCount MoneyValueWithCount)
        {
         List.Add(MoneyValueWithCount);
        }
       
        public CashValueWithCountList AcceptPayment(int Amount)
        {
            paymentAmount = Amount;
            var sumAmount = 0;
            do
            {
                Console.Write("Angi betaling (eks: 7x5kr betyr sju femkroner): ");
                var paymentString = Console.ReadLine();
                var newCashWithCount = CashValueListParser.ParseCashString(paymentString, CashItemValuesList);
                if (newCashWithCount != null)
                {
                    Add(newCashWithCount);
                    sumAmount += newCashWithCount.Sum();
                    Console.WriteLine($"Du har betalt {sumAmount}kr.");
                }
                } while (sumAmount < paymentAmount);

            return List;
        }
        public void ShowReturnAmount()
        {
            var returnAmount = List.GetTotalValue()-paymentAmount;
            Console.WriteLine($"Du skal få tilbake {returnAmount}kr:");
            CashItemValuesList.Sort(returnAmount);
                
        
        }
    }
}
