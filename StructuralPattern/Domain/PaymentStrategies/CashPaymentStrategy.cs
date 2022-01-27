using StructuralPatterns.Interfaces;
using System;

namespace StructuralPatterns.Domain.PaymentStrategies
{
     class CashPaymentStrategy : IPaymentStrategy
     {
          public void Pay(double amount)
          {
               Console.WriteLine("Cash payment of " + amount + "$ executed successfully");
          }
     }
}
