﻿using StructuralPatterns.Interfaces;

namespace StructuralPatterns.Domain.PaymentStrategies
{
     class PaymentContext
     {
          private IPaymentStrategy _paymentStrategy;


          public void SetStrategy(IPaymentStrategy strategy)
          {
               _paymentStrategy = strategy;
          }

          public void ExecuteStrategy(double amount)
          {
               _paymentStrategy.Pay(amount);
          }
     }
}
