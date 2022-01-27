using StructuralPatterns.Enums;
using StructuralPatterns.Interfaces;
using System;

namespace StructuralPatterns.Domain.Models
{
     class SecretIngredient : IIngredient
     {
          public IngredientTypeEnum Type { get; }
          public float Price { get; }
          public int Supply { get; set; }

          public SecretIngredient(float price, int supply)
          {
               Array ingredientTypes = Enum.GetValues(typeof(IngredientTypeEnum));
               Random random = new();
               IngredientTypeEnum randomIngredient = (IngredientTypeEnum)ingredientTypes.GetValue(random.Next(ingredientTypes.Length));
               Type = randomIngredient;
               Price = price;
               Supply = supply;
          }
     }
}
