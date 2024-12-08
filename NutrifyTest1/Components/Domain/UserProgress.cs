namespace NutrifyTest1.Components.Domain
{
    public class UserProgress
    {
        public int UserProgressID { get; set; } // Primary Key
        public DateOnly Date { get; set; } 
        public float Weight { get; set; } 
        public int CaloriesConsumed { get; set; } 
        public string? NutrientsBreakdown { get; set; } 
        public int UserID { get; set; } // Foreign Key
    }
}

