using System.Collections.Generic;

namespace StructuralPatterns.Interfaces
{
     interface IProduct
     {
          List<IIngredient> Ingredients { get; }
          public double GetPrice();
          public IProduct Clone();
     }
}
