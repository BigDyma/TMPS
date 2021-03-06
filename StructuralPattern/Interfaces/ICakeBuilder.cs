using StructuralPatterns.Domain.Models;

namespace StructuralPatterns.Interfaces
{
     interface ICakeBuilder
     {
          ICakeBuilder AddDough(bool isGlutenFree = false);
          ICakeBuilder AddCream();
          ICakeBuilder AddCandiesDecorations(int units);
          ICakeBuilder AddFruits();
          ICakeBuilder AddChocolate(int units);
          ICakeBuilder AddSecreteIngredient();
          Cake Bake();
     }
}
