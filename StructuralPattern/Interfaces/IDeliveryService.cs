using System.Collections.Generic;

namespace StructuralPatterns.Interfaces
{
     interface IDeliveryService
     {
          public float Price { get; }
          public float MaxNumberOfUnits { get; }

          public void Deliver(List<IProduct> products);
     }
}
