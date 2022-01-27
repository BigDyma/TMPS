using StructuralPatterns.Domain.Models;
using System.Collections.Generic;

namespace StructuralPatterns.Interfaces
{
     interface IStructuralPatterns
     {
          List<MenuItem> GetMenuItems();
          IProduct OrderMenuItem(int id);
          void GetDelivery(List<IProduct> order);
     }
}
