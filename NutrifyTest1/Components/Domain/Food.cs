namespace NutrifyTest1.Components.Domain
{
    public class Food
    {
        public int FoodID { get; set; } // Primary Key
        public string Name { get; set; }
        public string? Barcode { get; set; }
        public string? Category { get; set; }  // Fruits, Vegetables, Proteins, Grains, Others
        public int ServingSize { get; set; }
        public string Nutrients { get; set; }
    }
}

