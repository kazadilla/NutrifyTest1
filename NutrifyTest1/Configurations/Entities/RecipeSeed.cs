using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutrifyTest1.Components.Domain;

namespace NutrifyTest1.Configurations.Entities
{
    public class RecipeSeed : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(
                new Recipe
                {
                    RecipeID = 1,
                    Name = "Banana Oatmeal",
                    TargetCalories = 250,
                    IngredientsList = "",
                    PreparationInstructions = "",
                },
                new Recipe
                {
                    RecipeID = 2,
                    Name = "Stir Fry Vege with Tofu",
                    TargetCalories = 300,
                    IngredientsList = "",
                    PreparationInstructions = "",
                }
            );
        }
    }
}
