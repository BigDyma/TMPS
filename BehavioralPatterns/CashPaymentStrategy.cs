using System;

namespace BehavioralPatterns.PaymentStrategies
{
     public class CashPaymentStrategy : IPaymentStrategy
     {
          public void Pay(double amount)
          {
               Console.WriteLine("Cash payment of " + amount + "$ executed successfully");
          }
     }
}
