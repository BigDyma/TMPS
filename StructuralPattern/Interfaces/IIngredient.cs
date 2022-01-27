using StructuralPatterns.Enums;

namespace StructuralPatterns.Interfaces
{
     interface IIngredient
     {
          IngredientTypeEnum Type { get; }
          float Price { get; }
          int Supply { get; set; }
     }
}
