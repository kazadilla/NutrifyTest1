namespace NutrifyTest1.Components.Domain
{
    public class Recipe
    {
        public int RecipeID { get; set; } // Primary Key
        public string Name { get; set; }
        public string IngredientsList { get; set; } // JSON string or delimited format
        public int TargetCalories { get; set; }
        public string PreparationInstructions { get; set; }
    }
}
