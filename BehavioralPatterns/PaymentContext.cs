
namespace BehavioralPatterns.PaymentStrategies
{
     public class PaymentContext
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
