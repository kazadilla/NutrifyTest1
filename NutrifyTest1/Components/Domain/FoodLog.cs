namespace NutrifyTest1.Components.Domain
{
    public class FoodLog
    {
        public int FoodLogID { get; set; } // Primary Key
        public DateOnly Date { get; set; } 
        public TimeOnly Time { get; set; }
        public int ServingSizeLogged { get; set; }
        public int TotalCalories { get; set; }
        public int UserID { get; set; } // Foreign Key
        public int FoodID { get; set; } // Foreign Key
    }
}

